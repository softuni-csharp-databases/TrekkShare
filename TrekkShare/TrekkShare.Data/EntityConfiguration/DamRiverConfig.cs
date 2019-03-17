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
            builder.HasKey(x => new { x.DamId, x.RiverId });

            builder
                .HasOne(d => d.Dam)
                .WithMany(d => d.Sources)
                .HasForeignKey(d => d.DamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(d => d.River)
                .WithMany(d => d.DamRivers)
                .HasForeignKey(d => d.RiverId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
