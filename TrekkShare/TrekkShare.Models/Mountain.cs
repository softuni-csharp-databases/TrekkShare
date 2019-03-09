using System.Linq;

namespace TrekkShare.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Mountain
    {
        public Mountain()
        {
            this.Peaks = new HashSet<Peak>();
            this.MountainRivers = new HashSet<MountainRiver>();
            this.Cottages = new HashSet<Cottage>();
            this.Routes = new HashSet<Route>();
            this.Caves = new HashSet<Cave>();
            this.Lakes = new HashSet<Lake>();
        }

        public int MountainId { get; set; }

        [Required]
        public string Name { get; set; }

        public double Altitude { get; set; }

        public Peak HighestPeak => this.Peaks
            .OrderByDescending(x => x.PeakElevation).FirstOrDefault();

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Peak> Peaks { get; set; }
        public ICollection<MountainRiver> MountainRivers { get; set; }
        public ICollection<Cottage> Cottages { get; set; }
        public ICollection<Route> Routes { get; set; }
        public ICollection<Cave> Caves { get; set; }
        public ICollection<Lake> Lakes { get; set; }
    }
}
