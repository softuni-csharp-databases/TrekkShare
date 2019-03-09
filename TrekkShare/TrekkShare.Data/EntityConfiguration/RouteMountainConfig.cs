namespace TrekkShare.Data.EntityConfiguration
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TrekkShare.Models;

    public class RouteMountainConfig : IEntityTypeConfiguration<RouteMountain>
    {
        public void Configure(EntityTypeBuilder<RouteMountain> builder)
        {
            builder.HasKey(x => new { x.RouteId, x.MountainId });

            builder.HasOne(x => x.Route)
                .WithMany(x => x.RouteMountains)
                .HasForeignKey(x => x.RouteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Mountain)
                .WithMany(x => x.RouteMountains)
                .HasForeignKey(x => x.MountainId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
