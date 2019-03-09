namespace TrekkShare.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class River
    {
        public River()
        {
            this.Waterfalls = new HashSet<Waterfall>();
        }

        public int RiverId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Length { get; set; }

        public int Elevation { get; set; }

        public int FlowStrength { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Discharge { get; set; }

        public int MountainId { get; set; }

        public int CountryId { get; set; }

        public ICollection<Waterfall> Waterfalls { get; set; }
        //OPTIONAL: kayak trips, boat trips
    }
}