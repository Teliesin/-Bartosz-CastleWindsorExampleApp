using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CastleWindsorExampleApp.Bowls;
using CastleWindsorExampleApp.DogLeads;
using CastleWindsorExampleApp.Dogs;
using CastleWindsorExampleApp.Huts;
using CastleWindsorExampleApp.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorExampleApp.Infrastructure
{
    public class Installer : IWindsorInstaller
    {
        public void Install(
            IWindsorContainer container,
            IConfigurationStore store)
        {
            container.Register(
                Component.For<IDogLead>().ImplementedBy<BlueDogLead>(),
                Component.For<IDogLead>().ImplementedBy<RedDogLead>(),
                Component.For<IHut>().ImplementedBy<SmallHut>(),
                Component.For<IBowl>().ImplementedBy<SmallBowl>().LifeStyle.Transient.Named("Adamowy"),
                Component.For<IDog>()
                    .ImplementedBy<Dalmatian>()
                    .Named("D")
                    .LifeStyle.Transient
                    .DependsOn(
                        Dependency.OnComponent<IDogLead, BlueDogLead>()),
                Component.For<LogInterceptor>().ImplementedBy<LogInterceptor>(),
                Component.For<IDog>()
                    .ImplementedBy<York>()
                    .DependsOn(
                        Dependency.OnComponent<IHut, SmallHut>(),
                        Dependency.OnComponent<IBowl, SmallBowl>(),
                        Dependency.OnComponent<IDogLead, RedDogLead>()
                        )
                    .Named("Adamowy")
                    .LifeStyle.Transient
                    .Interceptors<LogInterceptor>(),
                  Component.For<IDog>()
                    .ImplementedBy<York>()
                    .DependsOn(
                        Dependency.OnComponent<IHut, SmallHut>(),
                        Dependency.OnComponent<IBowl, SmallBowl>(),
                        Dependency.OnComponent<IDogLead, BlueDogLead>()
                        )
                    .Named("Łukaszowy")
                   // .Interceptors<>
                );


        }
    }
}