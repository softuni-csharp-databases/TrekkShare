namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Routes")]
    public class River
    {
        [Key]
        public int RiverId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Length { get; set; }

        public int Elevation { get; set; }

        public int FlowStrength { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Discharge { get; set; }

        [ForeignKey(nameof(MountainId))]
        public int MountainId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }

        //OPTIONAL: kayak trips, boat trips
    }
}