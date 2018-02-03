namespace TreehouseDefense
{
    class Invader
    {

        /**
         *  Jeremy's Solution
         **/

        private int _Health = 10;
        private readonly Path _path;

        public MapLocation Location => _pathStep.GetLocationAt(_pathStep);

        // property
        public int Health { get; set; } = 2;

        public Invader( Path path )
        {
            _path = path;

        
        }

        public void Move() => _pathStep += 1;

        // a way to decrease health
        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
    }
}