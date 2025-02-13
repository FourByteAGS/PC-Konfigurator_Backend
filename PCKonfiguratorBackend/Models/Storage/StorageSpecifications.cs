using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class StorageSpecifications
    {
        [Key]
        public Guid id { get; set; }
        public int capacity { get; set; }
        public string schnittstelle { get; set; } 
        public int readSpeeed { get; set; }
        public int writeSpeeed { get; set; }
    }
}
