namespace TreehouseDefense
{
    class Invader
    {

        private readonly Path _path;
        private int _pathStep = 0;

        // Shorthanded way vs the whole other way
        public MapLocation Location { get; private set; } // change into a computed property, so the Getter is COMPUTED each time it's called
        
        public Invader( Path path )
        {
            _path = path;
            Location = path.GetLocationAt(_pathStep); 
        }

        public void Move()
        {
            _pathStep += 1; 
            Location = _path.GetLocationAt(_pathStep); 
        }


    }
}