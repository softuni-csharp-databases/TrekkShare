namespace TrekkShare.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class River
    {
        public River()
        {
            this.Waterfalls = new HashSet<Waterfall>();
            this.RiverCountries = new HashSet<RiverCountry>();
            this.MountainRivers = new HashSet<MountainRiver>();
            this.Dams = new HashSet<DamRiver>();
        }

        [Key]
        public int RiverId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Length { get; set; }

        public int Elevation { get; set; }

        public int FlowStrength { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Discharge { get; set; }

        public ICollection<RiverCountry> RiverCountries { get; set; }
        public ICollection<MountainRiver> MountainRivers { get; set; }
        public ICollection<Waterfall> Waterfalls { get; set; }
        public ICollection<DamRiver> Dams { get; set; }

        //OPTIONAL: kayak trips, boat trips
    }
}