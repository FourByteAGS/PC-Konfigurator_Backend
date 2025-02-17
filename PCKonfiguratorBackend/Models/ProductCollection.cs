using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class ProductCollection
    {
        public ProductCollection(Guid token)
        {
            this.token = token;
        }
        
        [Key]
        public Guid id { get; set; }
        public Guid token { get; set; }
        public FormFactor? formFactor { get; set; }
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
