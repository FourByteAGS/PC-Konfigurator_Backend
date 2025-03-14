﻿using System.ComponentModel.DataAnnotations;

namespace PCKonfiguratorBackend.Models
{
    public class Fan
    {
        [Key]
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? manufacturer { get; set; }
        public float? price { get; set; }
        public string? image { get; set; }
        public FanSpecifications fanSpecifications { get; set; } = new FanSpecifications();
        public Dimensions dimensions { get; set; } = new Dimensions();
    }
}
