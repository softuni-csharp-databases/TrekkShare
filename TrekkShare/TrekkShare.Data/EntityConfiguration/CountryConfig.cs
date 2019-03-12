namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasMany(e => e.RiverCountries)
                .WithOne(e => e.Country);

            builder.HasMany(e => e.Provinces)
                .WithOne(e => e.Country);

            builder.Property(e => e.Name)
                .HasColumnType("NVARCHAR(30)")
                .HasMaxLength(30)
                .IsUnicode();
        }
    }
}
