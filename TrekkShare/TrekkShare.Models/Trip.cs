namespace TrekkShare.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

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
        public Route Route { get; set; }

        [Required]
        public TimeSpan Length { get; set; }

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
        [Required]
        public int CottageId { get; set; }
        public Cottage Cottage { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
