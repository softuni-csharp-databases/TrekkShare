using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrekkShare.Models;

namespace TrekkShare.Data.EntityConfiguration
{
    public class PeakConfig : IEntityTypeConfiguration<Peak>
    {
        public void Configure(EntityTypeBuilder<Peak> builder)
        {
            builder
                .HasKey(p => p.PeakId);

            builder
                .Property(p => p.PeakName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.PeakElevation)
                .IsRequired();

            builder
                .HasOne(p => p.Mountain)
                .WithMany(p => p.Peaks)
                .HasForeignKey(p => p.PeakId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.GeoLocation)
                .WithMany(p => p.Peaks)
                .HasForeignKey(p => p.GeoLocationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
