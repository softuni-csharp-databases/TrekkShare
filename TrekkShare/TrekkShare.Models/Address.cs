namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TrekkShare.Services.Contracts;

    public class Address : IAddress
    {
        private int id;
        private string text;
        private int townId;
        private Town town;

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
