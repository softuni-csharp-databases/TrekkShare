using System.ComponentModel.DataAnnotations;
using NetTopologySuite.Geometries;
using TrekkShare.Models.Enums.RouteEnums;

namespace TrekkShare.Models
{
    public class Peak
    {
        [Key]
        public int PeakId { get; set; }

        [Required]
        public string PeakName { get; set; }

        public int PeakElevation { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public int GeoLocationId { get; set; }
        public Point GeoLocation { get; set; }
    }
}
