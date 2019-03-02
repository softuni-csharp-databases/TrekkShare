namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TrekkShare.Models.Enums.RouteEnums;

    public class Route
    {
        [Key]
        public int RouteId { get; set; }

        //[ForeignKey("Mountain")]
        [Required]
        public int MountainId { get; set; }

        [Required]
        public double Length { get; set; }
        
        [Required]
        public double Denivelation { get; set; }

        [Required]
        public TerrainType TerrainType { get; set; }

        [Required]
        public DifficultyLevel DifficultyLevel { get; set; }

        // Това може да е отделен клас ? Някой добави таск в meistertask, но никой не го е поел.
        [Required]
        public EquipmentLevel RecommendedEquipmentLevel { get; set; }
    }
}
