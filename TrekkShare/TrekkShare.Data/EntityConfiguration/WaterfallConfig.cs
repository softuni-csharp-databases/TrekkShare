namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class WaterfallConfig : IEntityTypeConfiguration<Waterfall>
    {
        public void Configure(EntityTypeBuilder<Waterfall> builder)
        {
            builder.HasKey(w => w.WaterfallId);

            builder.Property(w => w.Name)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();

            builder.Property(w => w.DomesticName)
                .HasMaxLength(50)
                .IsUnicode();

            builder.Property(w => w.Description)
                .HasMaxLength(400);

            builder.HasOne(w => w.River)
                .WithMany(r => r.Waterfalls)
                .HasForeignKey(w => w.RiverId);
        }
    }
}