using System;
using System.Collections.Generic;
using System.Text;

namespace TrekkShare.Models
{
    public class RiverCountry
    {
        public int RiverId { get; set; }
        public River River { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
