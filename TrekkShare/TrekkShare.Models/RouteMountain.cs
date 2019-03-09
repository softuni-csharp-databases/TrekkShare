namespace TrekkShare.Models
{
    public class RouteMountain
    {
        public int RouteId { get; set; }
        public Route Route { get; set; }

        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }
    }
}
