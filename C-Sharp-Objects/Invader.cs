namespace TreehouseDefense
{
    class Invader
    {

        /* Refactoring this class with more
         * 'Syntatic Sugar' = or more condensed code
         * Properties always return a value
         * 
         */

        private readonly Path _path;
        private int _pathStep = 0;


        //public MapLocation Location
        //{
        //    get
        //    {
        //        return _path.GetLocationAt(_pathStep);
        //    }

        //}

        // This only works with Computed Properties
        // Condensed into ...
        public MapLocation Location => _pathStep.GetLocationAt(_pathStep);


        public Invader( Path path )
        {
            _path = path;
        
        }

        //public void Move()
        //{
        //    _pathStep += 1; 

        //}

        // Works for Methods has() which means Method
        // Condensed into ...
        public void Move() => _pathStep += 1;


    }
}