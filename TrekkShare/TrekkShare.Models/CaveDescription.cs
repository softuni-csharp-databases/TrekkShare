using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security;

namespace TrekkShare.Models
{
    public class CaveDescription
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(600)")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(600)")]
        public string History{ get; set;}

        [Column(TypeName = "nvarchar(450)")]
        public string Legend { get; set; }

    }
}
