namespace TrekkShare.Data
{
    using Microsoft.EntityFrameworkCore;

    using EntityConfiguration;
    using TrekkShare.Models;
    using ConnectionProject;

    public class TrekkShareContext : DbContext
    {
        public TrekkShareContext()
        {

        }

        public TrekkShareContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Route> Routes { get; set; }

        public DbSet<Trip> Trips { get; set; }

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
            modelBuilder.ApplyConfiguration(new MountainConfig());
            modelBuilder.ApplyConfiguration(new RouteConfig());
            modelBuilder.ApplyConfiguration(new TouristTripConfig());
            modelBuilder.ApplyConfiguration(new PeakConfig());
        }
    }
}
