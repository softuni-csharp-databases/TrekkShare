namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class UserConfig :  IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(p => p.Tourist)
                .WithOne(u => u.User)
                .HasForeignKey<Tourist>(u => u.UserId);

            builder.Property(u => u.Username)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(u => u.FirstName)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(u => u.MiddleName)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(u => u.LastName)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(e => e.Email)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(p => p.Phone)
                .HasMaxLength(30);

            builder.HasIndex(e => e.Email)
                .IsUnique();

            builder.HasIndex(u => u.Username)
                .IsUnique();
        }
    }
}
