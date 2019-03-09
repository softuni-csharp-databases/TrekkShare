namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TrekkShare.Models;

    public class CottageConfig : IEntityTypeConfiguration<Cottage>
    {
        public void Configure(EntityTypeBuilder<Cottage> builder)
        {
            builder.HasKey(c => c.CottageId);

            builder.Property(c => c.Name)
                .IsUnicode();

            builder.HasOne(c => c.Mountain)
                .WithMany(m => m.Cottages)
                .HasForeignKey(c => c.MountainId);

            //TODO: Add relation to GeoLocation
        }
    }
}
