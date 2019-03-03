namespace TrekkShare.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Province
    {
        public Province()
        {
            this.Municipalities = new HashSet<Municipality>();
        }

        [Key]
        public int ProvinceId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }


        public HashSet<Municipality> Municipalities { get; set; }
    }
}
