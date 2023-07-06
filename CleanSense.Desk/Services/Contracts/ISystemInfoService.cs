using CleanSense.Desk.Models;

namespace CleanSense.Desk.Services.Contracts
{
    public interface ISystemInfoService
    {
        CpuData getCpuInformation();
    }
}
