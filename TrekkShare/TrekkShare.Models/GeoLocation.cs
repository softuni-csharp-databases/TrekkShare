using System;
using System.Collections.Generic;
using System.Text;
using NetTopologySuite.Geometries;

namespace TrekkShare.Models
{
    public class GeoLocation
    {
        public int Id { get; set; }

        public Point Location { get; set; }

        public string Address { get; set; }
    }
}
