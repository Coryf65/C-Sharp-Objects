namespace TreehouseDefense
{
    class Invader
    {

        private readonly Path _path;
        private int _pathStep = 0;

        //NOW a computed Property ...
        // replaces the property that has a field, a getter, and a setter
        // the user of this property does not need to know that the location 
        //of this property is computed from the _path and the _pathstep field
        // all they need to know is that they can type invader.location and 
        // get the location of the invader on the map

            // Properties should do simple things LIKLE getting and setting data
            
        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }

        }

        public Invader( Path path )
        {
            _path = path;
        
        }

        public void Move()
        {
            _pathStep += 1; 
         
        }


    }
}