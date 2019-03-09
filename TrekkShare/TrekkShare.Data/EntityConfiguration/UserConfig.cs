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
                .HasColumnType("VARCHAR(30)")
                .HasMaxLength(30)
                .IsRequired()
                .IsUnicode();

            builder.Property(u => u.FirstName)
                .HasColumnType("VARCHAR(40)")
                .HasMaxLength(40)
                .IsRequired()
                .IsUnicode();

            builder.Property(u => u.MiddleName)
                .HasColumnType("VARCHAR(30)")
                .HasMaxLength(30)
                .IsRequired(false)
                .IsUnicode();

            builder.Property(u => u.LastName)
                .HasColumnType("VARCHAR(40)")
                .HasMaxLength(40)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Email)
                .HasColumnType("VARCHAR(60)")
                .HasMaxLength(60)
                .IsRequired()
                .IsUnicode();

            builder.Property(p => p.Phone)
                .HasMaxLength(30);

            builder.HasIndex(e => e.Email)
                .IsUnique();

            builder.HasIndex(u => u.Username)
                .IsUnique();
        }
    }
}
