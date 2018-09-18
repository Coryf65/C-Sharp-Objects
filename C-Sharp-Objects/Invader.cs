using System;

namespace C_Sharp_Objects
{
    class Invader
    {

        /// <summary>
        ///  Base Invader Class
        ///  has some interfaces that we expose to other classes so they can interact with this one
        ///  We override how these sub classes behave by using Polymorphism
        ///  Location
        ///  HasScored
        ///  Health
        ///  IsNeutralized
        ///  IsActive
        ///  Move()
        ///  DecreaseHealth()
        /// </summary>

        private int _pathStep = 0;

        private readonly Path _path;

        //Readonly Property ~
        //int StepSize { get { return 1; } }

        // OR write the Readonly Property as ...
        //  and instead init to 1
        // also set as protected which is only available for this class and it's sub classes
        protected virtual int StepSize { get; } = 1;
       

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        // property
        public virtual int Health { get; protected set; } = 2;

        //Computed Proerty true if the invader reaches the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        //True if the invader health is less than or equal to it's helath
        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader( Path path )
        {
            _path = path;

        
        }

        // Using a Virtual Property
        public virtual void Move() => _pathStep += StepSize;

        // a way to decrease health
        //Now a Virtual Method so sub classes can implement this in different ways
        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            Console.WriteLine("Shot and HIT an Invader");

        }
    }
}