namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class MunicipalityConfig : IEntityTypeConfiguration<Municipality>
    {
        public void Configure(EntityTypeBuilder<Municipality> builder)
        {
            builder.HasOne(e => e.Province)
                .WithMany(e => e.Municipalities)
                .HasForeignKey(e => e.ProvinceId);

            builder.Property(e => e.Name)
                .HasColumnType("NVARCHAR(30)")
                .HasMaxLength(30)
                .IsUnicode();
        }
    }
}
