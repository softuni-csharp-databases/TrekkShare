namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class ProvinceConfig : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder
                .HasKey(p => p.ProvinceId);

            builder
                .HasMany(p => p.Municipalities)
                .WithOne(m => m.Province);

            builder
                .Property(p => p.Name)
                .IsUnicode()
                .HasMaxLength(75)
                .IsRequired();
        }
    }
}
