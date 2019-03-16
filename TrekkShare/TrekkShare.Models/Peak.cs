using System.ComponentModel.DataAnnotations;
using NetTopologySuite.Geometries;
using TrekkShare.Models.Enums.RouteEnums;

namespace TrekkShare.Models
{
    public class Peak
    {
        private const int highestPeak = 8848;

        public int PeakId { get; set; }

        public string PeakName { get; set; }

        [Range(1, highestPeak)]
        public int PeakElevation { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }

        public int GeoLocationId { get; set; }
        public Point GeoLocation { get; set; }
    }
}
