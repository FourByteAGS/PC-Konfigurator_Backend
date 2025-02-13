using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class TowerCompatibility
    {
        [Key]
        public Guid id {  get; set; }
        public float maxCpuCoolerHeight { get; set; }
        public float maxGpuLenght { get; set; }
    }
}
