namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class RiverCountryConfig : IEntityTypeConfiguration<RiverCountry>
    {
        public void Configure(EntityTypeBuilder<RiverCountry> builder)
        {
            builder
                .HasKey(x => new {x.CountryId, x.RiverId});

            builder.HasOne(x => x.Country)
                .WithMany(x => x.RiverCountries)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.River)
                .WithMany(x => x.RiverCountries)
                .HasForeignKey(x => x.RiverId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
