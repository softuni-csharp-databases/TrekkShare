namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class CottageConfig : IEntityTypeConfiguration<Cottage>
    {
        public void Configure(EntityTypeBuilder<Cottage> builder)
        {
            builder.HasKey(c => c.CottageId);

            builder.Property(c => c.Name)
                .IsUnicode()
                .IsRequired();

            builder.HasOne(c => c.Mountain)
                .WithMany(m => m.Cottages)
                .HasForeignKey(c => c.MountainId);

            builder.HasOne(cottage => cottage.GeoLocation)
                .WithMany(geoLocation => geoLocation.Cottages)
                .HasForeignKey(cottage=>cottage.GeoLocationId);
        }
    }
}
