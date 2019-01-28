using System;
using Autofac;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<MainService>();
            containerBuilder.RegisterType<SubAService>();
            containerBuilder.RegisterType<Client>();
            containerBuilder.RegisterType<SubBService>();
            var container = containerBuilder.Build();

            var mainService = container.Resolve<MainService>();
            mainService.Run();

            Console.WriteLine("Finish...");
            Console.ReadLine();
        }
    }
}