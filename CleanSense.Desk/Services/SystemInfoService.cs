using CleanSense.Desk.Models;
using CleanSense.Desk.Services.Contracts;
using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanSense.Desk.Services
{
    internal class SystemInfoService : ISystemInfoService
    {
        public async Task<CpuData> GetCpuInformationAsync()
        {
            try
            {
                CpuData cpu = new CpuData()
                {
                    CoreCount = 0,
                    CoreTemps = new Dictionary<int, int>()
                };

                Computer computer = new Computer { CPUEnabled = true };
                computer.Open();

                await Task.Run(() =>
                {
                    foreach (var hardwareItem in computer.Hardware)
                    {
                        if (hardwareItem.HardwareType == HardwareType.CPU)
                        {
                            // Access the CPU's temperature sensors
                            foreach (var sensor in hardwareItem.Sensors)
                            {
                                if (sensor.SensorType == SensorType.Temperature)
                                {
                                    // Read the temperature value
                                    cpu.CoreTemps.Add(cpu.CoreCount, Convert.ToInt32(sensor.Value));
                                    cpu.CoreCount++;
                                }
                            }
                        }
                    }
                });

                computer.Close();
                return cpu;
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}

