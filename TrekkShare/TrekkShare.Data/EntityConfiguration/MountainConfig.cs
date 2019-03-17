namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class MountainConfig : IEntityTypeConfiguration<Mountain>
    {
        public void Configure(EntityTypeBuilder<Mountain> builder)
        {
            builder.HasKey(m => m.MountainId);

            builder.Property(m => m.Name)
                .IsUnicode()
                .IsRequired();

            builder.HasMany(p => p.Peaks)
                .WithOne(m => m.Mountain)
                .HasForeignKey(m => m.MountainId);

            builder.HasMany(cv => cv.Caves)
                .WithOne(m => m.Mountain)
                .HasForeignKey(m => m.MountainId);

            builder.HasMany(ct => ct.Cottages)
                .WithOne(m => m.Mountain)
                .HasForeignKey(m => m.MountainId);

            builder.HasMany(l=>l.Lakes)
                .WithOne(m=>m.Mountain)
                .HasForeignKey(m => m.MountainId);

        }
    }
}
