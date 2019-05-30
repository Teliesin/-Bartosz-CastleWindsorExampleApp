using Castle.Windsor;
using CastleWindsorExampleApp.Bowls;
using CastleWindsorExampleApp.DogLeads;
using CastleWindsorExampleApp.Dogs;
using CastleWindsorExampleApp.Huts;
using CastleWindsorExampleApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tego narazie nie ma
            //WindsorContainer container = new WindsorContainer();

            //container.Install(new Installer());

            //var dog = container.Resolve<IDog>("D");
            #endregion

            WindsorContainer container = new WindsorContainer();
            container.Install(new Installer());

            //container.Resolve<York>();

            var dogA1 = container.Resolve<IDog>("Adamowy");
            dogA1.CounterUp();
            var dogA2 = container.Resolve<IDog>("Adamowy");
            dogA2.CounterUp();
            var dogA3 = container.Resolve<IDog>("Adamowy");
            dogA3.CounterUp();

            var dogŁ = container.Resolve<IDog>("Łukaszowy");

            IDog dog = new York(new SmallBowl(), new BlueDogLead(), new SmallHut());
            IDog dog2 = new York(new SmallBowl(), new RedDogLead(), new SmallHut());
        }
    }
}
