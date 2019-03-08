namespace TrekkShare.Data
{
    using Microsoft.EntityFrameworkCore;

    using EntityConfiguration;
    using TrekkShare.Models;

    public class TrekkShareContext : DbContext
    {
        public TrekkShareContext()
        {

        }

        public TrekkShareContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Cave> Caves { get; set; }
        public DbSet<Cottage> Cottages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Mountain> Mountains { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Peak> Peaks { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<River> Rivers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<TouristTrip> TouristTrips { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Waterfall> Waterfalls { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //TODO move file in a appsettings.json file
                optionsBuilder.UseSqlServer("Server=;Database=TrekkShare;Integrated Security=true"/*Configuration.ConnectionString*/);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new MountainConfig());
            modelBuilder.ApplyConfiguration(new RouteConfig());
            modelBuilder.ApplyConfiguration(new TouristTripConfig());
            modelBuilder.ApplyConfiguration(new PeakConfig());
            modelBuilder.ApplyConfiguration(new WaterfallConfig());
        }
    }
}
