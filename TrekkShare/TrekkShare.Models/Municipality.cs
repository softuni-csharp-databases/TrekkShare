namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Municipality
    {
        [Key]
        public int MunicipalityId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
