using System;
using System.Collections.Generic;
using System.Text;

namespace TrekkShare.Models
{
    public class MountainRiver
    {
        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }

        public int RiverId { get; set; }
        public River River { get; set; }
    }
}
