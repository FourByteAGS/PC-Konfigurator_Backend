﻿using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class Mainboard
    {
        [Key]
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? manufacturer { get; set; }
        public float? price { get; set; }
        public string? image { get; set; }
        public MainboardSpecifications mainboardSpecifications { get; set; } = new MainboardSpecifications();
        public Dimensions dimensions { get; set; } = new Dimensions();
    }
}
