using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrekkShare.Models;

namespace TrekkShare.Data.EntityConfiguration
{
    public class MountainConfig : IEntityTypeConfiguration<Mountain>
    {
        public void Configure(EntityTypeBuilder<Mountain> builder)
        {
            builder.HasOne(x => x.HighestPeak)
                .WithOne(x => x.Mountain)
                .HasForeignKey<Mountain>(x => x.HighestPeakId);
        }
    }
}
