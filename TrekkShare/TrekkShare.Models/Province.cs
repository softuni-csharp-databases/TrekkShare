namespace TrekkShare.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Province
    {
        public Province()
        {
            this.Municipalities = new HashSet<Municipality>();
        }

        [Key]
        public int ProvinceId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(75)")]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Municipality> Municipalities { get; set; }
    }
}
