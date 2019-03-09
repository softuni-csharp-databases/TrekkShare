using Microsoft.EntityFrameworkCore;
using TrekkShare.Data;

namespace TrekkShare.App
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    using Core;
    using Core.Contracts;
    using Services;
    using Services.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            var service = ConfigureServices();
            Engine engine = new Engine(service);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            serviceCollection.AddDbContext<TrekkShareContext>(options =>
                options.UseSqlServer(Configuration.ConnectionString));

            //serviceCollection.AddAutoMapper(cfg => cfg.AddProfile<TrekkShareProfile>());

            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();
            serviceCollection.AddTransient<IUserService, UserService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}