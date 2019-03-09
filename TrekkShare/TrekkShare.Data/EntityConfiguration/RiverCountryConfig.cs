using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrekkShare.Models;

namespace TrekkShare.Data.EntityConfiguration
{
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
