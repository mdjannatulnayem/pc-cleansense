using CleanSense.Desk.Models;
using CleanSense.Desk.Services.Contracts;
using OpenHardwareMonitor.Hardware;
using System;

namespace CleanSense.Desk.Services
{
    internal class SystemInfoService : ISystemInfoService
    {
        public CpuData getCpuInformation()
        {
            try
            {
                CpuData cpu = new CpuData() { CoreCount = 0 };
                Computer device = new Computer() { CPUEnabled = true };
                device.Open();

                // Delay for 50 milisecond
                System.Threading.Thread.Sleep(50);

                foreach (var hardwareItem in device.Hardware)
                {
                    if (hardwareItem.HardwareType == HardwareType.CPU)
                    {
                        // Access the CPU's temperature sensors
                        foreach (var sensor in hardwareItem.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                // Read the temperature value
                                cpu.CoreTemps.Add(cpu.CoreCount,Convert.ToInt32(sensor.Value));
                                cpu.CoreCount++;
                            }
                        }
                    }
                }
                device.Close();
                return cpu;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
