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

        public Address(string text)
        {
            //this.Id = AssignAddressId();
            //this.Text = text;
            //this.TownId = Town.AssignTownId();
            //Town town = 
        }

        [Key]
        public int Id { get;  }
        public string Text { get; }
        [ForeignKey(Town(Id))]
        public int TownId { get; }
        public Town Town { get; }

        private static void AssignAddressId()
        {
            //this.Id++;
        }
    }
}
