using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class TowerCompatibility
    {
        [Key]
        public Guid id {  get; set; }
        public decimal maxCpuCoolerHeight { get; set; }
        public decimal maxGpuLenght { get; set; }
    }
}
