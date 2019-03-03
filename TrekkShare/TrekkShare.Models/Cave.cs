using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrekkShare.Models
{
    public class Cave
    
    {[Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Name { get; set; }
        
        public decimal TicketPrice { get; set; }

        public int StartingTime { get; set; }

        public int EndingTime { get; set; }

        public int TimeIntervalWithGuide { get; set; }

        public int CharacteristicsId { get; set; }
      

        public int CaveDescriptionId { get; set; }
        
        public CaveDescription CaveDescription { get; set; }
        
        public CaveCharacteristic Characteristics { get; set; }

        //public int TownId { get; set; }

        // public Town Town { get; set; }

    }
}
