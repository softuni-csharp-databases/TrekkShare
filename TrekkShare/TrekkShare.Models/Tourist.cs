namespace TrekkShare.Models
{
    using System.Collections.Generic;
    using Enums;

    public class Tourist
    {
        public Tourist()
        {
            this.TouristTrips = new HashSet<TouristTrip>();
        }

        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public Experience Experience { get; set; }

        public int TripsCount { get; set; }

        public ICollection<TouristTrip> TouristTrips { get; set; }
    }
}
