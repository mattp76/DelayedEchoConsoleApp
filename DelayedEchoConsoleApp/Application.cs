using DelayedEchoConsoleApp.Interfaces;
using System;
using static DelayedEchoConsoleApp.Program;

namespace DelayedEchoConsoleApp
{
    public class Application : IApplication
    {
        private readonly IEchoAppService _service;
        public Application(IEchoAppService service)
        {
            _service = service;
        }

        public void Run()
        {
            _service.WriteToTheApp();
        }
    }
}
