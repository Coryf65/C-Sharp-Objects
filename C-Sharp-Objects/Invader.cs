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
            _path = path;
            Location = path.GetLocationAt(_pathStep); // DRY (Don't Repeat Yourself)
        }

        public void Move()
        {
            _pathStep += 1; // if we want to update the code we have to remember to change this field BUT instead we are going to change it up
            Location = _path.GetLocationAt(_pathStep); // DRY (Don't Repeat Yourself) these two are similar
        }


    }
}