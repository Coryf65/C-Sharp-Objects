namespace TreehouseDefense
{
    class Invader
    {

        /**
         *  Challenger Approaching !!!!!!!
         * Give the Invader's Health, be disabled, health remaining 
         * hit and decrement helath
         * **/

        private int _Health = 10;
        private readonly Path _path;
        private int _pathStep = 0;
        private string _missShot = "0";

        public MapLocation Location => _pathStep.GetLocationAt(_pathStep);


        public Invader( Path path )
        {
            _path = path;
        
        }

        public void Move() => _pathStep += 1;

        // when a tower hits the invader
        public void HitSuccess() => _Health -= 1;

        public string HitFailed => _missShot;
    }
}