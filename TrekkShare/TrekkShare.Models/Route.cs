namespace TrekkShare.Models
{
    using TrekkShare.Models.Enums.RouteEnums;

    public class Route
    {
        public int RouteId { get; set; }

        public int MountainId { get; set; }

        public double Length { get; set; }

        public double Denivelation { get; set; }

        public TerrainType TerrainType { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public EquipmentLevel RecommendedEquipmentLevel { get; set; }
    }
}
