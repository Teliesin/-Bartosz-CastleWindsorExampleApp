using Castle.Windsor;
using CastleWindsorExampleApp.Dogs;
using CastleWindsorExampleApp.Infrastructure;
using System;

namespace CastleWindsorExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = new WindsorContainer();
            container.Install(new Installer());

            IDog york = container.Resolve<IDog>("Adamowy");
            IDog york2 = container.Resolve<IDog>("Łukaszowy");

            IDog dalmatin = container.Resolve<IDog>();

            Console.ReadKey();
        }
    }
}