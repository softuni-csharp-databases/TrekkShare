using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrekkShare.Models;

namespace TrekkShare.Data.EntityConfiguration
{
    public class DamConfig : IEntityTypeConfiguration<Dam>
    {
        public void Configure(EntityTypeBuilder<Dam> builder)
        {
            builder
                .HasKey(d => d.DamId);

            builder
                .Property(d => d.Name)
                .HasMaxLength(50);
        }
    }
}
