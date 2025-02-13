using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class ProductCollection
    {
        [Key]
        public Guid id { get; set; }
        public Guid token { get; set; }
        public CPU? selectedCPU { get; set; }
        public Tower? selectedTower { get; set; }
        public CPUFan? selectedCPUFan { get; set; }
        public Mainboard? selectedMainboard  { get; set; }
        public RAM? selectedRAM { get; set; }   
        public Fan? selectedFan { get; set; }
        public Storage? selectedStorage { get; set; }
        public PSU? selectedPSU { get; set; }
        public GPU? selectedGPU { get; set; }

    }
}
