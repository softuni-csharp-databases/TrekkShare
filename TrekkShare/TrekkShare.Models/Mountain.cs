namespace TrekkShare.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Mountain
    {
        public Mountain()
        {
            this.Peaks = new HashSet<Peak>();
            this.Rivers = new HashSet<River>();
            this.Cottages = new HashSet<Cottage>();
            this.Routes = new HashSet<Route>();
            this.Caves = new HashSet<Cave>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Altitude { get; set; }

        //public int HighestPeakId { get; set; }
        //public Peak HighestPeak { get; set; }

        //public int CountryId { get; set; }
        //public Country Country { get; set; }

        public ICollection<Peak> Peaks { get; set; }
        public ICollection<River> Rivers { get; set; }
        public ICollection<Cottage> Cottages { get; set; }
        public ICollection<Route> Routes { get; set; }
        public ICollection<Cave> Caves { get; set; }
    }
}
