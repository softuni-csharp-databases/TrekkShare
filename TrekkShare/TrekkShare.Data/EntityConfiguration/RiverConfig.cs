namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class RiverConfig : IEntityTypeConfiguration<River>
    {
        public void Configure(EntityTypeBuilder<River> builder)
        {
           builder.HasKey(r=>r.RiverId);

            builder.Property(r=>r.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
