using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrekkShare.Models;

namespace TrekkShare.Data.EntityConfiguration
{
    public class MountainRiverConfig : IEntityTypeConfiguration<MountainRiver>
    {
        public void Configure(EntityTypeBuilder<MountainRiver> builder)
        {
            builder.HasKey(x => new { x.MountainId, x.RiverId });

            builder.HasOne(x => x.Mountain)
                .WithMany(x => x.MountainRivers)
                .HasForeignKey(x => x.MountainId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.River)
                .WithMany(x => x.MountainRivers)
                .HasForeignKey(x => x.RiverId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
