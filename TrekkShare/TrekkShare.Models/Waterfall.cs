namespace TrekkShare.Models
{
    public class Waterfall
    {
        public int WaterfallId { get; set; }

        /// <summary>
        /// Represents the main international name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  If any / Represents historical, specific, local name of the waterfall 
        /// </summary>
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
        public string Description { get; set; }

        //In the class River should have property public Hashset<Waterfall> Waterfalls
        //navigation property for River
        public int RiverId { get; set; }
        public River River { get; set; }
    }
}