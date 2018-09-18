using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    class StrongInvader : InvaderBase
    {
        // property
        public override int Health { get; protected set; } = 2;

        //Constructor
        public StrongInvader(Path path) : base(path) // Inherit the base class and pass into the base, the path
        {

        }
    }
}
