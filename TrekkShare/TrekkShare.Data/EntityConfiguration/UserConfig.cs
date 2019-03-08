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
                .WithOne(i => i.User)
                .HasForeignKey<Tourist>(b => b.UserId);

            builder.Property(u => u.Username)
                .HasColumnType("VARCHAR(30)")
                .HasMaxLength(30)
                .IsRequired()
                .IsUnicode();

            builder.Property(u => u.Email)
                .HasColumnType("VARCHAR(60)")
                .HasMaxLength(60)
                .IsRequired()
                .IsUnicode();

            builder.Property(p => p.Phone)
                .HasMaxLength(30);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.HasIndex(u => u.Username)
                .IsUnique();
        }
    }
}
