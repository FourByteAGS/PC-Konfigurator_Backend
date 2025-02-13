using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class CPUSpecification
    {
        [Key]
        public Guid id { get; set; }
        public int l2Cache { get; set; }
        public int l3Cache { get; set; }
        public int maxTemp { get; set; }
        public int threads { get; set; }
        public int core { get; set; }
        public double baseClock { get; set; }
        public double boostClock { get; set; }
        public Socket socket { get; set; }
        public CPUMemory cpuMemory { get; set; }
        
    }
}
