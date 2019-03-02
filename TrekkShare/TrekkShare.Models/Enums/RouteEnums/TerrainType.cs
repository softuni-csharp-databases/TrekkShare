using System;

namespace TrekkShare.Models.Enums.RouteEnums
{
    public enum TerrainType
    {
        // Някой ако може да измисли по-адекватни да заповяда.

        /// <summary>
        /// Region surrounded with a lot of trees. 
        /// Usually located in cold or more temperate climates 
        /// </summary>
        Forest,

        /// <summary>
        /// Straightforward mountain terrain.
        /// </summary>
        Mountain,

        /// <summary>
        /// Open Open terrains are also called an open country or even open ground, and they are flat areas of land that are free of trees, buildings, and anything else that can obstruct a person’s view. 
        /// </summary>
        Open,

        /// <summary>
        /// A valley is found between mountains or hills and often includes a river that runs through it. 
        /// Also called a dale or a depression, a valley is bigger in length than it is in its width. 
        /// </summary>
        Valley,
        /// <summary>
        /// Hills are pieces of land that rise to a peak and are above sea level. 
        /// They are similar to mountains except they are lower and not nearly as steep. 
        /// </summary>
        Hillside          
    }
}
