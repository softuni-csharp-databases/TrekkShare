namespace TrekkShare.Models

{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Waterfall
    {
        public Waterfall(string name, int riverId)
        {
            this.Name = name;
            this.RiverId = riverId;
        }
        public Waterfall(string name, int riverId, string domesticName)
            : this(name, riverId)
        {
            this.DomesticName = domesticName;
        }
        public Waterfall(string name, int riverId, string domesticName,int height)
            : this(name, riverId,domesticName)
        {
            this.Height = height;
        }
        public Waterfall(string name, int riverId, string domesticName, int height, int width)
            : this(name, riverId, domesticName,height)
        {
            this.Width = width;
        }
        public Waterfall(string name, int riverId, string domesticName, int height, int width, int flowRate)
            : this(name, riverId, domesticName, height,width)
        {
            this.FlowRate = flowRate;
        }
        public Waterfall(string name, int riverId, string domesticName, int height, int width, int flowRate, string description)
            : this(name, riverId, domesticName, height, width,flowRate)
        {
            this.Description = description;
        }

        [Key] public int WaterfallId { get; set; }

        /// <summary>
        /// Represents the main international name
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        /// <summary>
        ///  If any / Represents historical, specific, local name of the waterfall 
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string DomesticName { get; set; }

        /// <summary>
        /// meter / Represents the currentWaterfall height
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// meter / Represents the currentWaterfall height
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// liter per second / Represent the the volume of water passing over the waterfall
        /// </summary>
        public int? FlowRate { get; set; }

        // property/ies for GPS Locations

        //Image property?

        /// <summary>
        /// Free text up to 400 symbols.
        /// Additional information about the waterfall
        /// </summary>
        [Column(TypeName = "nvarchar(400)")]
        public string Description { get; set; }

        //In the class River should have property public Hashset<Waterfall> Waterfalls
        //navigation property for River
        public int RiverId { get; set; }
        public River River { get; set; }
    }
}