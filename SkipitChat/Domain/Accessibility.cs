using System;
using System.ComponentModel.DataAnnotations;
namespace SkipitChat.Domain
{
    public class Accessibility
    {

        [Key]
        public Guid Id { get; set; }
        public string StationName { get; set; }
        public bool Elevator { get; set; }
        public bool DisabledService { get; set; }
        public bool Stairs { get; set; }
        public bool Escalator { get; set; }
        public bool Toilet { get; set; }
        public bool WaitingRoom { get; set; }
        public bool BikeParking { get; set; }
        public bool TicketMachine { get; set; }
        public string Comment { get; set; }
    }
}
