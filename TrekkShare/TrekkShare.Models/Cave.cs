using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrekkShare.Models
{[Table("Caves")]
    public class Cave
    
    {[Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        public decimal TicketPrice { get; set; }
        public int StartingTime { get; set; }
        public int EndingTime { get; set; }
        public int TimeIntervalWithGuide { get; set; }
        public int CharacteristicsId { get; set; }
        public int TownId { get; set; }

        public int CaveDescriptionId { get; set; }
        [ForeignKey(nameof(CaveDescriptionId))]
        public CaveDescription CaveDescription { get; set; }
        [ForeignKey(nameof(CharacteristicsId))]
        public CaveCharacteristic Characteristics { get; set; }
        //[ForeignKey(nameof(TownId))]
       // public Town Town { get; set; }
       
    }
}