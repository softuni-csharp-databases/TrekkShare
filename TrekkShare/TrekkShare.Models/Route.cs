namespace TrekkShare.Models
{
    using System.Collections.Generic;

    using Enums.RouteEnums;

    public class Route
    {
        public Route()
        {
            this.RouteMountains = new HashSet<RouteMountain>();
            this.Trips = new HashSet<Trip>();
        }

        public int RouteId { get; set; }

        public string Name { get; set; }

        public double Length { get; set; }

        public double Denivelation { get; set; }

        public TerrainType TerrainType { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public EquipmentLevel RecommendedEquipmentLevel { get; set; }

        public int StartPointId { get; set; }
        public GeoLocation StartPoint { get; set; }

        public int EndPointId { get; set; }
        public GeoLocation EndPoint { get; set; }

        public ICollection<RouteMountain> RouteMountains { get; set; }
        public ICollection<Trip> Trips { get; set; }

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
