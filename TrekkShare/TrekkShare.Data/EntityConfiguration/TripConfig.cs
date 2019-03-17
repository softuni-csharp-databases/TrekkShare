namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class TripConfig : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(x => x.TripId);

            builder.HasOne(x => x.Route)
                .WithMany(x => x.Trips)
                .HasForeignKey(x => x.RouteId);

            builder.HasOne(x => x.StartPoint)
                .WithMany(x => x.StartPointTrips)
                .HasForeignKey(x => x.StartPointId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.EndPoint)
                .WithMany(x => x.EndPointTrips)
                .HasForeignKey(x => x.EndPointId)
                .OnDelete(DeleteBehavior.Restrict);

            // TODO relation with Geo points and Cottage.
        }
    }
}
