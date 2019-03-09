using System;
using System.Collections.Generic;
using System.Text;
using NetTopologySuite.Geometries;

namespace TrekkShare.Models
{
    public class GeoLocation
    {
        public int GeoLocationId { get; set; }

        public Point Location { get; set; }

        public string Address { get; set; }

        public ICollection<Cave> Caves { get; set; }
        public ICollection<Lake> Lakes { get; set; }
        public ICollection<Cottage> Cottages { get; set; }
        public ICollection<Peak> Peaks { get; set; }
    }
}
