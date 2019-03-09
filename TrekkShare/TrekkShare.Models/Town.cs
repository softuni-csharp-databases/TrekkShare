using System.Collections.Generic;

namespace TrekkShare.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Town
    {
        public Town()
        {
            this.Addresses = new HashSet<Address>();
        }

        [Key]
        public int TownId { get; set; }

        [Required]
        public string Name { get; set; }

        public int MunicipalityId { get; set; }
        public Municipality Municipality { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
