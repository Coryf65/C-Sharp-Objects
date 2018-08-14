﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    class FastInvader : Invader 
    {
        //Property
        protected override int StepSize { get; } = 2;

        //Constructor
        public FastInvader(Path path) : base(path) // Inherit the base class and pass into the base the path
        {
          
        }
    }
}
