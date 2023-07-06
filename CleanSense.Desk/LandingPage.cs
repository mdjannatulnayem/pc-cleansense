using CleanSense.Desk.Models;
using CleanSense.Desk.Services;
using CleanSense.Desk.Services.Contracts;
using CleanSense.Desk.Utility;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanSense.Desk
{
    public partial class LandingPage : Form
    {
        bool connected;

        ISystemInfoService systemInfoService;

        CpuData cpu_t = new CpuData();

        SerialData serial = new SerialData();

        bool[] alert_sent = new bool[6];

        int sum = 0;

        DateTime lastSendTime = DateTime.Now;

        public LandingPage()
        {
            InitializeComponent();
            systemInfoService = new SystemInfoService();
            connected = false;
        }

        private void Btn_conn_disconn_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                try
                {
                    var port = port_add.Text;
                    UsbSerial.PortName = port;
                    UsbSerial.Open();
                    if (UsbSerial.IsOpen)
                    {
                        connected = true;
                        debug.Text += $"> Connected to {port}\n";
                        conn_status.Text = "Connected";
                        btn_conn_disconn.Text = "Cut off";
                    }
                    else
                    {
                        debug.Text += $"> Couldn't connect!\n";
                    }
                }
                catch (Exception ex)
                {

                    debug.Text += $"> {ex.Message}\n";
                }
            }
            else
            {                
                UsbSerial.Close();
                connected = false;
                conn_status.Text = "Disconnected";
                btn_conn_disconn.Text = "Connect";
            }
        }

        private async void Clk_Tick(object sender, EventArgs e)
        {
            if (connected)
            {               
                serial = await ReadSerialDataAsync();
                cpu_t = systemInfoService.getCpuInformation();
                for (int i = 0; i < 1000; i++);

                sum = 0;
                for (int i = 0; i < cpu_t.CoreCount; i++)
                {
                    sum += cpu_t.CoreTemps[i];
                }
                core_avg.Value = Convert.ToInt32(sum / cpu_t.CoreCount);
                sys_t.Value = serial.t;
                vbr_out.Text = serial.vb.ToString();
                dust_out.Text = serial.dust.ToString();
                smoke_out.Text = serial.smoke.ToString();
                mst_out.Text = serial.moist.ToString();

                if (core_avg.Value > 95)
                {
                    debug.Text += "# CPU TEMPERATURE TOO HIGH!\n";
                    if (!alert_sent[0] || (alert_sent[0] && (DateTime.Now - lastSendTime).TotalMinutes > 2))
                    {
                        SystemNotifier.Notify("CleanSense", "CPU temperature reaching too high!", notifyIcon1);
                        alert_sent[0] = true;
                        lastSendTime = DateTime.Now;
                    }
                }

                if (serial.t > 45)
                {
                    debug.Text += "# SYSTEM TEMPERATURE TOO HIGH!\n";
                    if (!alert_sent[1] || (alert_sent[1] && (DateTime.Now - lastSendTime).TotalMinutes > 5))
                    {
                        SystemNotifier.Notify("CleanSense", "System temperature reaching too high!", notifyIcon1);
                        alert_sent[1] = true;
                        lastSendTime = DateTime.Now;
                    }
                }

                if (serial.vb > 10)
                {
                    debug.Text += "# MIGHT HAVE GROWN DUST ON COOLING FANS!\n";
                    if (!alert_sent[2] || (alert_sent[2] && (DateTime.Now - lastSendTime).TotalMinutes > 10))
                    {
                        SystemNotifier.Notify("CleanSense", "Might have grown dust on cooling fans!", notifyIcon1);
                        alert_sent[2] = true;
                        lastSendTime = DateTime.Now;
                    }
                }

                if (serial.dust > 400)
                {
                    debug.Text += "# SYSTEM HAS GROWN DUST!\n";
                    debug.Text += "# REQUIRES CLEANING!\n";
                    if (!alert_sent[3] || (alert_sent[3] && (DateTime.Now - lastSendTime).TotalMinutes > 5))
                    {
                        SystemNotifier.Notify("CleanSense", "Requires cleaning! System has grown dust!", notifyIcon1);
                        alert_sent[3] = true;
                        lastSendTime = DateTime.Now;
                    }

                }

                if (serial.smoke > 650)
                {
                    debug.Text += "# SMOKE DETECTED!\n";
                    debug.Text += "# REQUIRES CLEANING!\n";
                    if (!alert_sent[4] || (alert_sent[4] && (DateTime.Now - lastSendTime).TotalMinutes > 3))
                    {
                        SystemNotifier.Notify("CleanSense", "Requires cleaning! System has grown dust!", notifyIcon1);
                        alert_sent[4] = true;
                        lastSendTime = DateTime.Now;
                    }
                }

                if (serial.moist > 88)
                {
                    debug.Text += "# TOO MUCH HUMID INSIDE THE SYSTEM!\n";
                    if (!alert_sent[5] || (alert_sent[5] && (DateTime.Now - lastSendTime).TotalMinutes > 5))
                    {
                        SystemNotifier.Notify("CleanSense", "Too much humidity!", notifyIcon1);
                        alert_sent[5] = true;
                        lastSendTime = DateTime.Now;
                    }
                }

                // Done...!
            }
        }

        public async Task<SerialData> ReadSerialDataAsync()
        {
            if (!UsbSerial.IsOpen)
                UsbSerial.Open();

            try
            {
                byte[] buffer = new byte[UsbSerial.BytesToRead];
                int bytesRead = await UsbSerial.BaseStream.ReadAsync(buffer, 0, buffer.Length);
                string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                return JsonConvert.DeserializeObject<SerialData>(data);
            }
            catch (JsonException ex)
            {
                debug.Text += $"> Error deserializing serial data: {ex.Message}\n";
                return null;
            }
            catch (TimeoutException ex)
            {
                debug.Text += $"> Timeout reading from serial port: {ex.Message}\n";
                return null;
            }
        }

    }
}
