namespace TrekkShare.App.Core
{
    using System;
    using System.Data.SqlClient;
    using Microsoft.Extensions.DependencyInjection;

    using Contracts;

    public class Engine : IEngine
    {
        private readonly IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            var commandInterpreter = this.serviceProvider.GetService<ICommandInterpreter>();

            while (true)
            {
                try
                {
                    string[] input = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string result = commandInterpreter.Read(input);

                    Console.WriteLine(result);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (SqlException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
