using System;
using System.ComponentModel.DataAnnotations;

namespace SkipitChat.Domain
{
    public class CityPass
    {
        [Key]
        public Guid Id { get; set; }
        public int DurationInHour { get; set; }
        public float CityPass4Price { get; set; }
        public float CityPass99Price { get; set; }
    }
}
