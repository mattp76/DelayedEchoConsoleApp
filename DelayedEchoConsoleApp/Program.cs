using Autofac;
using DelayedEchoConsoleApp.Interfaces;
using DelayedEchoConsoleApp.IoC;

namespace DelayedEchoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = EchoAppRegistration.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}

