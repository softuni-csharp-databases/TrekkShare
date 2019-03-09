namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Address
    {
        public Address(int id, string text, int townId, Town town)
        {
            this.Id = id;
            this.Text = text;
            this.TownId = townId;
            this.Town = town;
        }

        [Key]
        public int AddressId { get; set; }

        //TODO move in AddressContext
        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string Text { get; set; }

        public int TownId { get; set; }
        public Town Town { get; set; }
    }
}
