using Autofac;
using DelayedEchoConsoleApp.Interfaces;
using DelayedEchoConsoleApp.Services;
using DelayedEchoConsoleApp;
using DelayedEcho;
using DelayedEcho.Interfaces;

namespace DelayedEchoConsoleApp.IoC
{
    public static class EchoAppRegistration
    {
        /// <summary>
        /// Configure
        /// Configure the IoC container with the relevant dependancies, using Autofac
        /// </summary>
        /// <param name="IConcreteClass"></param>
        /// <returns></returns>
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<EchoAppService>().As<IEchoAppService>();
            builder.RegisterType<ConcreteClass>().As<IConcreteClass>();

            return builder.Build();
        }
    }
}
