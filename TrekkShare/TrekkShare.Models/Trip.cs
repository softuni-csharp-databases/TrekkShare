namespace TrekkShare.Models
{
    using System;
    using System.Collections.Generic;

    using NetTopologySuite.Geometries;

    public class Trip
    {
        public Trip()
        {
            this.TouristTrips = new HashSet<TouristTrip>();
            this.Transports = new HashSet<Transport>();
        }

        public int TripId { get; set; }

        public int RouteId { get; set; }
        public Route Route { get; set; }

        public TimeSpan Length { get; set; }

        public int NightsCount { get; set; }

        public int StartPointId { get; set; }
        public Point StartPoint { get; set; }

        public int EndPointId { get; set; }
        public Point EndPoint { get; set; }

        public int MaxTouristsCount { get; set; }

        // NULLABLE
        //public Guide Guide { get; set; }

        public int? CottageId { get; set; }
        public Cottage Cottage { get; set; }

        public ICollection<TouristTrip> TouristTrips { get; set; }
        public ICollection<Transport> Transports { get; set; }
    }
}
