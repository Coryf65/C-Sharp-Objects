namespace TreehouseDefense
{
    class Invader
    {

        private readonly Path _path;
        private int _pathStep = 0;

        // Shorthanded way vs the whole other way
        public MapLocation Location { get; private set; }
        
        public Invader( Path path )
        {

            Location = path.GetLocationAt(_pathStep);
        }

        public void Move()
        {
            _pathStep += 1;
            Location = _path.GetLocationAt(_pathStep);
        }


    }
}