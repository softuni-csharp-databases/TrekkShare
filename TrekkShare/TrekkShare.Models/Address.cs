namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;

    public class Address
    {
        public Address()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int AddressId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(300)")]
        public string Text { get; set; }

        public int TownId { get; set; }
        public Town Town { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
