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

            // TODO relation with Geo points and Cottage.
        }
    }
}
