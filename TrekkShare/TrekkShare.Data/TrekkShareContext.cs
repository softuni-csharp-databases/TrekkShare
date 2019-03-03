namespace TrekkShare.Data
{
    using Microsoft.EntityFrameworkCore;

    using EntityConfiguration;

    public class TrekkShareContext : DbContext
    {
        public TrekkShareContext()
        {
            
        }

        public TrekkShareContext(DbContextOptions options) 
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //TODO move file in a appsettings.json file
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
        }
    }
}
