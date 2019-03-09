namespace TrekkShare.App.Core
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string ControllerSuffix = "Controller";

        private readonly IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public string Read(string[] input)
        {
            string controllerName = input[0];
            string methodName = input[1];
            string[] parameters = input.Skip(2).ToArray();

            var controller = Assembly.GetCallingAssembly().GetTypes()
                .FirstOrDefault(x => x.Name == controllerName + ControllerSuffix);

            if (controller == null)
            {
                throw new InvalidOperationException("Controller doesn't exists!");
            }

            var method = controller.GetMethod(methodName);

            if (method == null)
            {
                throw new InvalidOperationException("Method doesn't exists!");
            }

            var constructor = controller.GetConstructors()
                .First();

            var constructorParameters = constructor.GetParameters()
                .Select(x => x.ParameterType)
                .ToArray();

            var service = constructorParameters.Select(this.serviceProvider.GetService)
                .ToArray();

            var controllerInstances = Activator.CreateInstance(controller, service );

            var methodResult = (string)method
                .Invoke(controllerInstances, new object[] { parameters });

            return methodResult;
        }
    }
}
