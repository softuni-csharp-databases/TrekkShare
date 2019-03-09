using System;
using System.Collections.Generic;
using System.Text;
using NetTopologySuite.Geometries;

namespace TrekkShare.Models
{
    public class GeoLocation
    {
        public GeoLocation()
        {
            this.Caves = new HashSet<Cave>();
            this.Lakes = new HashSet<Lake>();
            this.Cottages = new HashSet<Cottage>();
            this.Peaks = new HashSet<Peak>();
        }

        public int GeoLocationId { get; set; }

        public Point Location { get; set; }

        public ICollection<Cave> Caves { get; set; }
        public ICollection<Lake> Lakes { get; set; }
        public ICollection<Cottage> Cottages { get; set; }
        public ICollection<Peak> Peaks { get; set; }
    }
}
