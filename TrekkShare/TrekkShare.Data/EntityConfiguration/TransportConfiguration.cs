namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TrekkShare.Models;

    public class TransportConfiguration : IEntityTypeConfiguration<Transport>
    {
        public void Configure(EntityTypeBuilder<Transport> builder)
        {
            builder.HasKey(x => x.TransportId);

            builder.Property(t => t.TransportType)
                .IsRequired();

            builder.Property(x => x.DepartureAddress)
                .IsRequired();
        }
    }
}
