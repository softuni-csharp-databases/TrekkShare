namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class CaveConfig : IEntityTypeConfiguration<Cave>
    {
        public void Configure(EntityTypeBuilder<Cave> builder)
        {
            builder
                .HasKey(c => c.CaveId);

            builder
                .Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();

             builder.HasOne(c => c.Mountain)
                .WithMany(x => x.Caves)
                .HasForeignKey(x => x.MountainId);
        }
    }
}

