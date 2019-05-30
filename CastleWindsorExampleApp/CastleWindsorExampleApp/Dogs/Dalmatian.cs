using CastleWindsorExampleApp.Bowls;
using CastleWindsorExampleApp.DogLeads;
using CastleWindsorExampleApp.Huts;

namespace CastleWindsorExampleApp.Dogs
{
    public class Dalmatian : IDog
    {
        IBowl Bowl { get; set; }
        IDogLead DogLead { get; set; }
        IHut Hut { get; set; }

        public Dalmatian(IBowl bowl, IDogLead dogLead, IHut hut)
        {
            Bowl = bowl;
            DogLead = dogLead;
            Hut = hut;
        }

        public void CounterUp()
        {
            throw new System.NotImplementedException();
        }
    }
}