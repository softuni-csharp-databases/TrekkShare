
namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;
    using NetTopologySuite.Geometries;

    public class Lake
    {       
        public int LakeId { get; set; }
             
        public string Name { get; set; }

        public double Surface { get; set; }

        public double Depth { get; set; }

        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }

        public int GeoLocationId { get; set; }
        public GeoLocation GeoLocation { get; set; }
    }
}
