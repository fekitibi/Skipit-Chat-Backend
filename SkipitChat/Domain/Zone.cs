using System;
using System.ComponentModel.DataAnnotations;

namespace SkipitChat.Domain
{
    public class Zone
    {
        [Key]
        public int Id { get; set; }
        public int DurationInMinute { get; set; }
        public float PriceChildren { get; set; }
        public float PriceDisabled { get; set; }
        public float PriceAdult { get; set; }
        public float PriceElderly { get; set; }
        public float Animal { get; set; }
        public float Bycicle { get; set; }
    }
}
