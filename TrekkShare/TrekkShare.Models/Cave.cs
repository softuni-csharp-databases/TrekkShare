using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrekkShare.Models
{
    public class Cave
    
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public decimal TicketPrice { get; set; }

        public int StartingTime { get; set; }

        public int EndingTime { get; set; }

        public int TimeIntervalWithGuide { get; set; }
       
        public int TownId { get; set; }

         public Town Town { get; set; }

    }
}
