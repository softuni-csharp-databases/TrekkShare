namespace TrekkShare.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Trip
    {
        public Trip()
        {
            this.TouristTrips = new HashSet<TouristTrip>();
        }

        [Key]
        public int TripId { get; set; }

        public int RouteId { get; set; }
        public Route Route { get; set; }

        public TimeSpan Length { get; set; }

        public int NightsCount { get; set; }

        //[Required]
        //public Address StartingPoint { get; set; }

        //[Required]
        //public Address EndPoint { get; set; }

        public int MaxTouristsCount { get; set; }

        // NULLABLE
        //public Guide Guide { get; set; }

        // Място за нощувка. NULLABLE ако преходът е еднодневен.
        public int? CottageId { get; set; }
        public Cottage Cottage { get; set; }

        public ICollection<TouristTrip> TouristTrips { get; set; }
    }
}
