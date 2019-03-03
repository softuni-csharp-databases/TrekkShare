namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Town
    {
        [Key]
        public int TownId { get; set; }

        [Required]
        public string Name { get; set; }

        public int MunicipalityId { get; set; }
        public Municipality Municipality { get; set; }
    }
}
