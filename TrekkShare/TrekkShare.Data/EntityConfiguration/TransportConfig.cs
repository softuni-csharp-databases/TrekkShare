namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class TransportConfig : IEntityTypeConfiguration<Transport>
    {
        public void Configure(EntityTypeBuilder<Transport> builder)
        {
            builder.HasKey(x => x.TransportId);
            
            builder.ToTable("Transport");

            builder.Property(t => t.TransportType)
                .IsRequired();

            builder.Property(x => x.DepartureAddress)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
