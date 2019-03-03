namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Cottage
    {
        [Key]
        public int CottageId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int MountainId { get; set; }
    }
}