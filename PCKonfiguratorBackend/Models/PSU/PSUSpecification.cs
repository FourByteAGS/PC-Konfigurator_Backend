using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class PSUSpecification
    {
        [Key]
        public Guid id { get; set; }
        public int rpm { get; set; }
        public int power { get; set; }
        public string noiseLevel { get; set; }
        public string certifications {  get; set; }
        public string connectors { get; set; }

    }
}
