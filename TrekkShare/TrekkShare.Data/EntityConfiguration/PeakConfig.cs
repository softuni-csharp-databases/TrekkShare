using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrekkShare.Models;

namespace TrekkShare.Data.EntityConfiguration
{
    public class PeakConfig : IEntityTypeConfiguration<Peak>
    {
        public void Configure(EntityTypeBuilder<Peak> builder)
        {
            builder.HasOne(x => x.Mountain)
                .WithMany(x => x.Peaks)
                .HasForeignKey(x => x.PeakId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
