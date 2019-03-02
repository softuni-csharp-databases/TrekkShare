namespace TrekkShare.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Trips")]
    public class Trip
    {
        public Trip()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int TripId { get; set; }

        [Required]
        public int RouteId { get; set; }

        [ForeignKey(nameof(RouteId))]
        [Required]
        public Route Route { get; set; }

        /// <summary>
        ///  Продължителност в дни.
        /// </summary>
        [Required]
        public int Length { get; set; }

        [Required]
        public int NightsCount { get; set; }

        //[Required]
        //public Address StartingPoint { get; set; }

        //[Required]
        //public Address EndPoint { get; set; }

        [Required]
        public int MaxTouristsCount { get; set; }

        // NULLABLE
        //public Guide Guide { get; set; }

        // Място за нощувка. NULLABLE ако преходът е еднодневен.
        //public Cottage Cottage { get; set; }

        public HashSet<User> Users { get; set; }
    }
}
