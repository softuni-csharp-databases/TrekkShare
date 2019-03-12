namespace TrekkShare.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Municipality
    {
        public Municipality()
        {
            this.Towns = new HashSet<Town>();
        }

        [Key]
        public int MunicipalityId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int ProvinceId { get; set; }
        public Province Province { get; set; }

        public ICollection<Town> Towns { get; set; }
    }
}
