using System;

namespace C_Sharp_Objects
{


    interface IMappable
    {
        MapLocation Location { get; }
    }

    internal interface IMovable
    {
        void Move();
    }

    interface IInvader : IMappable, IMovable
    {          
        
        bool HasScored { get; }
        
        int Health { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void DecreaseHealth(int factor);


    }
  
}
