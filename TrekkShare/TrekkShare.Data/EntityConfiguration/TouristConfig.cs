namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class TouristConfig : IEntityTypeConfiguration<Tourist>
    {
        public void Configure(EntityTypeBuilder<Tourist> builder)
        {
            builder.HasKey(t => t.TouristId);

            builder.HasOne(t => t.User)
                .WithOne(u => u.Tourist);

            builder.HasMany(t => t.TouristTrips)
                .WithOne(tr => tr.Tourist)
                .HasForeignKey(tr => tr.TouristId);
        }
    }
}
