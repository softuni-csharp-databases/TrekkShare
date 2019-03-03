namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class RouteConfig : IEntityTypeConfiguration<Route>
    {

        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.HasOne(x => x.Mountain)
                .WithMany(x => x.Routes)
                .HasForeignKey<Mountain>(x => x.MountainId);
        }
    }
}
