namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;

    using TrekkShare.Models.Enums.RouteEnums;
    
    public class Route
    {
        [Key]
        public int RouteId { get; set; }

        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }

        public double Length { get; set; }
        
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
