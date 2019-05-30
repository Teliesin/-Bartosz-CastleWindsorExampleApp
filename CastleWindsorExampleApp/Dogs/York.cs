using CastleWindsorExampleApp.Bowls;
using CastleWindsorExampleApp.DogLeads;
using CastleWindsorExampleApp.Huts;

namespace CastleWindsorExampleApp.Dogs
{
    public class York : IDog
    {
        IBowl Bowl { get; set; }
        IDogLead DogLead { get; set; }
        IHut Hut { get; set; }

        public York(IBowl bowl, IDogLead dogLead, IHut hut)
        {
            Bowl = bowl;
            DogLead = dogLead;
            Hut = hut;
        }
    }
}