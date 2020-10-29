using System;
using System.ComponentModel.DataAnnotations;

namespace SkipitChat.Domain
{
    public class Zone
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int ZoneValue { get; set; }
        [Required]
        public int DurationInMinute { get; set; }
        [Required]
        public float PriceChildren { get; set; }
        [Required]
        public float PriceDisabled { get; set; }
        [Required]
        public float PriceAdult { get; set; }
        [Required]
        public float PriceElderly { get; set; }
        [Required]
        public float Animal { get; set; }
        [Required]
        public float Bycicle { get; set; }
    }
}
