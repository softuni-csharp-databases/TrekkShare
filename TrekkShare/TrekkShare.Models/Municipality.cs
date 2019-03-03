namespace TrekkShare.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Municipality
    {
        public Municipality()
        {
            this.Towns = new HashSet<Town>();
        }

        [Key]
        public int MunicipalityId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public HashSet<Town> Towns { get; set; }
    }
}
