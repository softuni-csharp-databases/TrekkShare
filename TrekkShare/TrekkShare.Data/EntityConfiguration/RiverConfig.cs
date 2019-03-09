using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrekkShare.Models;

namespace TrekkShare.Data.EntityConfiguration
{
    public class RiverConfig : IEntityTypeConfiguration<River>
    {
        public void Configure(EntityTypeBuilder<River> builder)
        {
           
        }
    }
}
