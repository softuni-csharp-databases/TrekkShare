namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;

    using TrekkShare.Models.Enums.RouteEnums;
    
    public class Route
    {
        [Key]
        public int RouteId { get; set; }

        [Required]
        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }

        [Required]
        public double Length { get; set; }
        
        [Required]
        public double Denivelation { get; set; }

        [Required]
        public TerrainType TerrainType { get; set; }

        [Required]
        public DifficultyLevel DifficultyLevel { get; set; }

        // Това може да е отделен клас ? Някой добави таск в meistertask, но никой не го е поел.
        [Required]
        public EquipmentLevel RecommendedEquipmentLevel { get; set; }

        public double StartLatitude { get; set; }

        public double StartLongitude { get; set; }

        public double EndLatitude { get; set; }

        public double EndLongitude { get; set; }

        //Optional: Calculate the distance
        //public double Distance => CalculateDistanceInMeters(StartLatitude, StartLongitude,
        //   EndLatitude, EndLongitude);

        //private double CalculateDistanceInMeters (double lat1, double lon1,
        //   double lat2, double lon2)
        //{
        //    var earthRadius = 6371e3;
        //    var lat1Radians = ToRadians(lat1);
        //    var lat2Radians = ToRadians(lat2);
        //    var latResultRadians = ToRadians(lat2 - lat1);
        //    var lonResultRadians = ToRadians(lon2 - lon1);

        //    var halfChordLength = Math.Sin(latResultRadians / 2) * Math.Sin(latResultRadians / 2) +
        //            Math.Cos(lat1Radians) * Math.Cos(lat2Radians) *
        //            Math.Sin(lonResultRadians / 2) * Math.Sin(lonResultRadians / 2);
        //    var angularDistanceRadius = 2 * Math.Atan2(Math.Sqrt(halfChordLength), Math.Sqrt(1 - halfChordLength));
        //    var totalMeters = earthRadius * angularDistanceRadius;

        //    return totalMeters;
        //}

        //private static double ToRadians(double val)
        //{
        //    return (Math.PI / 180) * val;
        //}
    }
}
