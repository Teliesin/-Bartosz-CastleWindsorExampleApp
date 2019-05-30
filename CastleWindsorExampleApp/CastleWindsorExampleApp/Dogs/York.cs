using CastleWindsorExampleApp.Bowls;
using CastleWindsorExampleApp.DogLeads;
using CastleWindsorExampleApp.Huts;
using System;
using System.Threading;

namespace CastleWindsorExampleApp.Dogs
{
    public class York : IDog
    {
        IBowl Bowl { get; set; }
        IDogLead DogLead { get; set; }
        IHut Hut { get; set; }

        int Counter { get; set; }

        public York(IBowl bowl, IDogLead dogLead, IHut hut)
        {
            Bowl = bowl;
            DogLead = dogLead;
            Hut = hut;
        }

        public void CounterUp()
        {
            Counter++;

            Random random = new Random();
            Thread.Sleep(random.Next(1, 1000));
        }

        public York()
        {
            Bowl = new SmallBowl();
            DogLead = new BlueDogLead();
            Hut = new BigHut();
        }
    }
}