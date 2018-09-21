using System;

namespace C_Sharp_Objects
{
    class Tower
    {
        //Constant where you cannot change the value after declaration
        //private const int _RANGE = 1;
        //private const int _POWER = 1;
        //private const double _ACCURACY = .75;

        //Changed our Constants to Properties
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        // Because this is static there can only be one of these no matter how many towers are created
        //Static Field

        // trying to use our own random class
        //private static readonly System.Random _random = new System.Random();

        

        // Every Tower object on the map can have a different location on the map
        private readonly MapLocation _loaction;

        public Tower(MapLocation location)
        {
            _loaction = location;
        }

        public bool IsSuccessfulShot()
        {
            return Random.NextDouble() < Accuracy;
        }
        
        public void FireOnInvaders(IInvader[] invaders)
        {

            //loop through each item in the collection
            foreach (IInvader invader in invaders)
            {
               
                // Do stuff
                // 1 is the grid size
                if (invader.IsActive && _loaction.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Target Down at: " + invader.Location);
                        }
                    }else
                    {
                        Console.WriteLine("Shot and Missed an Invader");
                    }

                      break;
                    
                }
            }
        }

    }
}