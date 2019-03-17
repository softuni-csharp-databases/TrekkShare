using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrekkShare.Models;

namespace TrekkShare.Data.EntityConfiguration
{
    public class DamRiverConfig : IEntityTypeConfiguration<DamRiver>
    {
        public void Configure(EntityTypeBuilder<DamRiver> builder)
        {
            builder
                .HasKey(dr => new { dr.DamId, dr.RiverId });

            builder
                .HasOne(d => d.Dam)
                .WithMany(d => d.Sources)
                .HasForeignKey(d => d.DamId);

            builder
                .HasOne(d => d.River)
                .WithMany(d => d.Dams)
                .HasForeignKey(d => d.RiverId);
        }
    }
}
