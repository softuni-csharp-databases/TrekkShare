namespace TrekkShare.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using TrekkShare.Models.Enums.RouteEnums;
    
    public class Route
    {
        [Key]
        public int RouteId { get; set; }

        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }

        public double Length { get; set; }
        
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

        public double Distance => CalculateDistanceInMeters(StartLatitude, StartLongitude,
           EndLatitude, EndLongitude);
        
        private double CalculateDistanceInMeters (double lat1, double lon1,
           double lat2, double lon2)
        {
            var R = 6371e3;
            var φ1 = ToRadians(lat1);
            var φ2 = ToRadians(lat2);
            var Δφ = ToRadians(lat2 - lat1);
            var Δλ = ToRadians(lon2 - lon1);

            var a = Math.Sin(Δφ / 2) * Math.Sin(Δφ / 2) +
                    Math.Cos(φ1) * Math.Cos(φ2) *
                    Math.Sin(Δλ / 2) * Math.Sin(Δλ / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c;

            return d;
        }

        private static double ToRadians(double val)
        {
            return (Math.PI / 180) * val;
        }
    }

}
