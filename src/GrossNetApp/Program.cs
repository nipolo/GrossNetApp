using System;

using GrossNetApp.Sellary;
using GrossNetApp.Sellary.Services;
using Autofac;

namespace GrossNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = BuildContainer();
            using var scope = container.BeginLifetimeScope();

            Console.WriteLine("Please, enter the Gross amount of money ...");
            var grossAmount = Convert.ToInt32(Console.ReadLine());
            var sellaryService = scope.Resolve<ISellaryService>();
            var netAmountOfMoney = sellaryService.CalculateNetPayment(grossAmount);

            Console.WriteLine("Net amount of money: " + netAmountOfMoney);
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new SellaryModule());
            var container = builder.Build();

            return container;
        }
    }
}
