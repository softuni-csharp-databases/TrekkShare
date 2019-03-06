namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    [Table("Addresses")]
    public class Address
    {
        public Address(int id, string text, int townId, Town town)
        {
            this.Id = id;
            this.Text = text;
            this.TownId = townId;
            Town town = town;
        }

        [Key]
        public int Id { get;  set; }
        
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string Text { get; set; }
        
        [ForeignKey(Town(Id))]
        public int TownId { get; set; }
        public Town Town { get; set; }
    }
}
