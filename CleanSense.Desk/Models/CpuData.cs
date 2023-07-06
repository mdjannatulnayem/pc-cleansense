using System.Collections.Generic;

namespace CleanSense.Desk.Models
{
    public class CpuData
    {
        public int CoreCount { get; set; }
        public Dictionary<int,int> CoreTemps { get; set; }
    }
}
