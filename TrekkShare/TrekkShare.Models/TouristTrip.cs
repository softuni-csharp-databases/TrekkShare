namespace TrekkShare.Models
{
    using System;

    public class TouristTrip
    {
        public int TouristId { get; set; }
        public Tourist Tourist { get; set; }

        public int TripId { get; set; }
        public Trip Trip { get; set; }

        public DateTime DateTime { get; set; }
    }
}