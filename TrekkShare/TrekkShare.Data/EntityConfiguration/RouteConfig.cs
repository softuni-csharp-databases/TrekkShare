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

            builder.HasOne(x => x.StartPoint)
                .WithMany(x => x.StartPointRoutes)
                .HasForeignKey(x => x.StartPointId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.EndPoint)
                .WithMany(x => x.EndPointRoutes)
                .HasForeignKey(x => x.EndPointId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired(true)
                .IsUnicode(true);
        }
    }
}
