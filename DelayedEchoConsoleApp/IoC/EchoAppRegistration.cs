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
