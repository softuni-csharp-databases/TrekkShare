using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrekkShareClasses
{
    [Table("Peaks")]
    public class Peak
    {

        [Key]
        public int PeakId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Peak Name cannot exceed 50 characters.")]
        public string PeakName { get; set; }

        public int PeakElevation { get; set; }

        //public DifficultyLevel DifficultyLevel { get; set; }

        //public int MountainId { get; set; }

        //[ForeignKey(nameof(MountainId))]
        //public Mountain Mountain { get; set; }

        //public int CountryId { get; set; }

        //[ForeignKey(nameof(CountryId))]
        //public Country Country { get; set; }
    }
}
