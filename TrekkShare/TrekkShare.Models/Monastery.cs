namespace TrekkShare.Models
{
    public class Monastery
    {
        public int MonasteryId { get; set; }

        public string MonasteryName { get; set; }

        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }

    }
}