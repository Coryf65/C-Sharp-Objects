using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    //going to display Polymorphism
    class ShieldedInvader : InvaderBase  //Inheriting the Base Class Invader
    {

        public override int Health { get; protected set; } = 2;

        public ShieldedInvader(Path path) : base(path) //Constructor pass the path parametyer to the base class
        {
            DecreaseHealth(0);
        }

        // So this will have keyword 'override' to say this is our own implementation of DecreaseHealth
        public override void DecreaseHealth(int factor)
        {
            // the invader will be hit approx 50% of the time
            if (Random.NextDouble() < .5)
            {
                // when it hits use the base class DecraseHealth no need to re-invent the wheel!
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at a Shielded Invader but it sustained no damage...");
            }
        }

    }
}
