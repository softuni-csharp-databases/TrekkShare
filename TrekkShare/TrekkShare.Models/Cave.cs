using NetTopologySuite.Geometries;

namespace TrekkShare.Models
{
    public class Cave
    {
        public int CaveId { get; set; }

        public string Name { get; set; }

        public decimal TicketPrice { get; set; }

        public int StartingTime { get; set; }

        public int EndingTime { get; set; }

        public int TimeIntervalWithGuide { get; set; }

        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }

        public int GeoLocationId { get; set; }
        public GeoLocation GeoLocation { get; set; }
    }
}
