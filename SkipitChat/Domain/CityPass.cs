using System;
using System.ComponentModel.DataAnnotations;

namespace SkipitChat.Domain
{
    public class CityPass
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int DurationInHour { get; set; }
        [Required]
        public float CityPass4Price { get; set; }
        [Required]
        public float CityPass99Price { get; set; }
    }
}
