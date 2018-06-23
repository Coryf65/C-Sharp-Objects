using System;

namespace C_Sharp_Objects
{
    class Tower
    {
        //Constant where you cannot change the value after declaration
        private const int _RANGE = 1;
        private const int _POWER = 1;
        private const double _ACCURACY = .75;

        // Because this is static there can only be one of these no matter how many towers are created
        private static readonly Random _random = new Random();

        // Every Tower object on the map can have a different location on the map
        private readonly MapLocation _loaction;

        public Tower(MapLocation location)
        {
            _loaction = location;
        }

        public bool IsSuccessfulShot()
        {
            return Tower._random.NextDouble() < _ACCURACY;
        }
        
        public void FireOnInvaders(Invader[] invaders)
        {

            //loop through each item in the collection
            foreach (Invader invader in invaders)
            {
               
                // Do stuff
                // 1 is the grid size
                if (invader.IsActive && _loaction.InRangeOf(invader.Location, _RANGE))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_POWER);
                        Console.WriteLine("Shot and HIT an Invader");
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Target Down");
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