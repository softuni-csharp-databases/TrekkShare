namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class RiverConfig : IEntityTypeConfiguration<River>
    {
        public void Configure(EntityTypeBuilder<River> builder)
        {
           
        }
    }
}
