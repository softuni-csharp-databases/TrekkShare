using System;
using System.Collections.Generic;
using System.Text;

namespace TrekkShare.Models
{
    public class Dam
    {
        public int DamId { get; set; }

        public string Name { get; set; }

        public double Area { get; set; }

        public int DamWallWidth { get; set; }

        public int DamWallHeight { get; set; }

        public string Description { get; set; }

        public int GeolocationId { get; set; }
        public GeoLocation GeoLocation { get; set; }

        public ICollection<DamRiver> Sources { get; set; }
    }
}
