using System;
using System.Collections.Generic;
using System.Text;

namespace TrekkShare.Models
{
    public class DamRiver
    {
        public int DamId { get; set; }
        public Dam Dam { get; set; }

        public int RiverId { get; set; }
        public River River { get; set; }
    }
}
