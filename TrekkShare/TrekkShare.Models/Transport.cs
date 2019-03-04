namespace TrekkShare.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using TrekkShare.Models.Enums.TransportEnums;

    public class Transport
    { 
        public int TransportId { get; set; }

        public TransportType TransportType { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }
        
        public string DepartureAddress { get; set; }

        public int Availableseats { get; set; }

        public decimal ExpectedCostPerPerson { get; set; }

        public int TripId { get; set; }
        public Trip Trip { get; set; }

        public int TownId { get; set; }
        public Town DepartureTown { get; set; }
    }
}
