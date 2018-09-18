using System;

namespace C_Sharp_Objects
{
    interface IInvader
    {

        // New interface
        // they don't have constructors, or implmentations,
        // they also only define public members

        // computed property, only needs a getter
        MapLocation Location { get; }
        
        //Computed Proerty true if the invader reaches the end of the path
        bool HasScored { get; }
        
        // property
        int Health { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        // Using a Virtual Property
        void Move();

        void DecreaseHealth(int factor);


    }
}
