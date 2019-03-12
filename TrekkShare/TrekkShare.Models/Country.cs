namespace TrekkShare.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        public Country()
        {
            this.Provinces = new HashSet<Province>();
            this.RiverCountries = new HashSet<RiverCountry>();
        }

        [Key]
        public int CountryId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Province> Provinces { get; set; }
        public ICollection<RiverCountry> RiverCountries { get; set; }
    }
}
