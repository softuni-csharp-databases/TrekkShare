namespace TrekkShare.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using TrekkShare.Models.Enums.TransportEnums;

    public class Transport
    { 
        [Key]
        public int TransportId { get; set; }

        [Required]
        public TransportType TransportType { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        [Required]
        public string DepartureAddress { get; set; }

        public int Availableseats { get; set; }

        public decimal ExpectedCostPerPerson { get; set; }

        public int TripId { get; set; }
        public Trip Trip { get; set; }

        public int TownId { get; set; }
        public Town DepartureTown { get; set; }
    }
}
