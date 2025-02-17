using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class Tower
    {
        [Key]
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? manufacturer { get; set; }
        public float? price { get; set; }
        public string? image { get; set; }
        public string? color { get; set; }
        public TowerType? towerType { get; set; }
        public FormFactor? formFactor { get; set; }
        public Dimensions dimensions { get; set; } = new Dimensions();
        public TowerCompatibility towerCompatibility { get; set; } = new TowerCompatibility();
    }
}
