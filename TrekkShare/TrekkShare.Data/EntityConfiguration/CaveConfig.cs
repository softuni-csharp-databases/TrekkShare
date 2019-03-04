

namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class CaveConfig: IEntityTypeConfiguration<Cave>
    {
        public void Configure(EntityTypeBuilder<Cave> builder)
        {
            builder
                .HasKey(c=>c.Id);

            builder
                .Property(c => c.Name)
                .HasColumnType("NVARCHAR(50)")
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();

            builder.HasOne(c => c.Characteristics)
                .WithMany(x => x.Caves)
                .HasForeignKey(x => x.CharacteristicsId);

            builder.HasOne(c => c.CaveDescription)
                .WithMany(x => x.Caves)
                .HasForeignKey(x=>x.CaveDescriptionId);

            builder.HasOne(c => c.Town)
                .WithMany(x => x.Caves)
                .HasForeignKey(x=>x.TownId);
        }
    }
}