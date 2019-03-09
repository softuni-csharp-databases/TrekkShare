namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class RouteConfig : IEntityTypeConfiguration<Route>
    {

        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.HasKey(x => x.RouteId);

            builder.Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired(true)
                .IsUnicode(true);

            builder.Property(x => x.StartGeoPoint)
                .IsRequired(true);

            builder.Property(x => x.EndGeoPoint)
                .IsRequired(true);
        }
    }
}
