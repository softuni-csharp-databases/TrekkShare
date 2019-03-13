namespace TrekkShare.Models
{
    using System.Collections.Generic;

    public class Province
    {
        public Province()
        {
            this.Municipalities = new HashSet<Municipality>();
        }

        public int ProvinceId { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<Municipality> Municipalities { get; set; }
    }
}
