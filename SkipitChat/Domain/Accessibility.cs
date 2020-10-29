using System;
using System.ComponentModel.DataAnnotations;
namespace SkipitChat.Domain
{
    public class Accessibility
    {

        [Key]
        public Guid Id { get; set; }
        [Required]
        public string StationName { get; set; }
        [Required]
        public bool Elevator { get; set; }
        [Required]
        public bool DisabledService { get; set; }
        [Required]
        public bool Stairs { get; set; }
        [Required]
        public bool Escalator { get; set; }
        [Required]
        public bool Toilet { get; set; }
        [Required]
        public bool WaitingRoom { get; set; }
        [Required]
        public bool BikeParking { get; set; }
        [Required]
        public bool TicketMachine { get; set; }
        public string? Comment { get; set; }
    }
}
