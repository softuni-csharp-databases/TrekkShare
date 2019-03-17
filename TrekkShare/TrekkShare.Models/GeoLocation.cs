namespace TrekkShare.Models
{
    using System.Collections.Generic;

    using NetTopologySuite.Geometries;

    public class GeoLocation
    {
        public GeoLocation()
        {
            this.Caves = new HashSet<Cave>();
            this.Lakes = new HashSet<Lake>();
            this.Cottages = new HashSet<Cottage>();
            this.Peaks = new HashSet<Peak>();
            this.StartPointRoutes = new HashSet<Route>();
            this.EndPointRoutes = new HashSet<Route>();
            this.StartPointTrips = new HashSet<Trip>();
            this.EndPointTrips = new HashSet<Trip>();
        }

        public int GeoLocationId { get; set; }

        public Point Location { get; set; }

        public ICollection<Cave> Caves { get; set; }
        public ICollection<Lake> Lakes { get; set; }
        public ICollection<Cottage> Cottages { get; set; }
        public ICollection<Peak> Peaks { get; set; }
        public ICollection<Route> StartPointRoutes { get; set; }
        public ICollection<Route> EndPointRoutes { get; set; }
        public ICollection<Trip> StartPointTrips { get; set; }
        public ICollection<Trip> EndPointTrips { get; set; }
    }
}
