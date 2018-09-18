using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    class FastInvader : InvaderBase
    {
        //Property
        protected override int StepSize { get; } = 2;

        //overriding the abstract method and setting the healthg to a default
        public override int Health { get; protected set; } = 2;

        //Constructor
        public FastInvader(Path path) : base(path) // Inherit the base class and pass into the base the path
        {
          
        }
    }
}
