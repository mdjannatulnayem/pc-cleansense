using CleanSense.Desk.Models;
using CleanSense.Desk.Services;
using CleanSense.Desk.Services.Contracts;
using CleanSense.Desk.Utility;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
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
                        writeLog($"Connected to {port}");
                        conn_status.Text = "Connected";
                        btn_conn_disconn.Text = "Cut off";
                        for (int i = 0; i < 1000; i++);
                    }
                    else
                    {
                        writeLog($"Couldn't connect!");
                    }
                }
                catch (Exception ex)
                {

                    writeLog($"{ex.Message}");
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
                UsbSerial.WriteLine("*");
                cpu_t = await systemInfoService.GetCpuInformationAsync();
                
                if (serial is null)
                    return;
                sys_t.Value = serial.t;
                vbr_out.Text = serial.vb.ToString();
                dust_out.Text = serial.dust.ToString();
                smoke_out.Text = serial.smoke.ToString();
                mst_out.Text = serial.moist.ToString();
                if (cpu_t.CoreCount == 0) 
                    return;
                core_avg.Value = cpu_t.CoreTemps[cpu_t.CoreCount-1];

                if (core_avg.Value > 95)
                {
                    writeLog("REQUIRES CLEANING!");
                    if (!alert_sent[0] || (alert_sent[0] && (DateTime.Now - lastSendTime).TotalMinutes > 2))
                    {
                        SystemNotifier.Notify("CleanSense", "CPU temperature reaching too high!", notifyIcon1);
                        alert_sent[0] = true;
                        lastSendTime = DateTime.Now;
                    }
                    UsbSerial.WriteLine("A");
                }

                if (serial.t > 45)
                {
                    writeLog("REQUIRES CLEANING!");
                    
                    if (!alert_sent[1] || (alert_sent[1] && (DateTime.Now - lastSendTime).TotalMinutes > 5))
                    {
                        SystemNotifier.Notify("CleanSense", "System temperature reaching too high!", notifyIcon1);
                        alert_sent[1] = true;
                        lastSendTime = DateTime.Now;
                    }

                    UsbSerial.WriteLine("A");

                    if (serial.t > 65) 
                    {
                        MessageBox.Show("System overhitting!Attempting immediate shutdown!");
                        Process.Start("shutdown", "/s /t 10"); 
                    }
                }

                if (serial.vb > 10)
                {
                    writeLog("REQUIRES CLEANING!");
                    if (!alert_sent[2] || (alert_sent[2] && (DateTime.Now - lastSendTime).TotalMinutes > 10))
                    {
                        SystemNotifier.Notify("CleanSense", "Might have grown dust on cooling fans!", notifyIcon1);
                        alert_sent[2] = true;
                        lastSendTime = DateTime.Now;
                    }
                    UsbSerial.WriteLine("A");
                }

                if (serial.dust > 400)
                {
                    writeLog("SYSTEM HAS GROWN DUST!");
                    writeLog("REQUIRES CLEANING!");
                    if (!alert_sent[3] || (alert_sent[3] && (DateTime.Now - lastSendTime).TotalMinutes > 5))
                    {
                        SystemNotifier.Notify("CleanSense", "Requires cleaning! System has grown dust!", notifyIcon1);
                        alert_sent[3] = true;
                        lastSendTime = DateTime.Now;
                    }

                    UsbSerial.WriteLine("A");

                }

                if (serial.smoke > 650)
                {
                    writeLog("SMOKE DETECTED!");
                    writeLog("REQUIRES CLEANING!");
                    if (!alert_sent[4] || (alert_sent[4] && (DateTime.Now - lastSendTime).TotalMinutes > 3))
                    {
                        SystemNotifier.Notify("CleanSense", "Requires cleaning! System has grown dust!", notifyIcon1);
                        alert_sent[4] = true;
                        lastSendTime = DateTime.Now;
                    }
                    UsbSerial.WriteLine("A");

                }

                if (serial.moist > 99)
                {
                    writeLog("TOO MUCH HUMID INSIDE THE SYSTEM!");
                    if (!alert_sent[5] || (alert_sent[5] && (DateTime.Now - lastSendTime).TotalMinutes > 5))
                    {
                        SystemNotifier.Notify("CleanSense", "Too much humidity!", notifyIcon1);
                        alert_sent[5] = true;
                        lastSendTime = DateTime.Now;
                    }
                    UsbSerial.WriteLine("A");
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
                Task<string> asyncTask = new Task<string>(serialRead);
                asyncTask.Start();
                string data = await asyncTask;
                return JsonConvert.DeserializeObject<SerialData>(data);
            }
            catch (Exception ex)
            {
                writeLog($"Exception while reading data: {ex.Message}");
                return null;
            }
        }

        private string serialRead()
        {
            string str = null;
            str = UsbSerial.ReadLine();
            return str;
        }

        private void writeLog(string log)
        {
            debug.Text += $"//{log}\n";
            debug.SelectionStart = debug.Text.Length;
            debug.ScrollToCaret();
        }


    }
}
