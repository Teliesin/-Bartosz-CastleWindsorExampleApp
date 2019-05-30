using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CastleWindsorExampleApp.Bowls;
using CastleWindsorExampleApp.DogLeads;
using CastleWindsorExampleApp.Dogs;
using CastleWindsorExampleApp.Huts;

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
                
                Component.For<IBowl>().ImplementedBy<SmallBowl>(),
                Component.For<IBowl>().ImplementedBy<BigBowl>(),
                
                Component.For<IHut>().ImplementedBy<SmallHut>(),
                Component.For<IHut>().ImplementedBy<BigHut>(),

                Component.For<IDog>()
                    .ImplementedBy<Dalmatian>()
                    .LifeStyle.Transient
                    .DependsOn(
                        Dependency.OnComponent<IDogLead, BlueDogLead>()),
              
                Component.For<IDog>()
                    .ImplementedBy<York>()
                    .DependsOn(
                        Dependency.OnComponent<IHut, SmallHut>(),
                        Dependency.OnComponent<IBowl, SmallBowl>(),
                        Dependency.OnComponent<IDogLead, RedDogLead>()
                        )
                    .Named("Adamowy")
                    .LifeStyle.Transient,
                    
                  Component.For<IDog>()
                    .ImplementedBy<York>()
                    .DependsOn(
                        Dependency.OnComponent<IHut, BigHut>(),
                        Dependency.OnComponent<IBowl, BigBowl>(),
                        Dependency.OnComponent<IDogLead, BlueDogLead>()
                        )
                    .Named("Łukaszowy")
                );
        }
    }
}