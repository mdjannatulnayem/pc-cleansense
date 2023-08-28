using CleanSense.Desk.Models;
using System.Threading.Tasks;

namespace CleanSense.Desk.Services.Contracts
{
    public interface ISystemInfoService
    {
        Task<CpuData> GetCpuInformationAsync();
    }
}
