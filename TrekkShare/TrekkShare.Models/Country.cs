namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
