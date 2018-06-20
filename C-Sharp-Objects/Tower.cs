namespace C_Sharp_Objects
{
    class Tower
    {
        //Constant where you cannot change the value after declaration
        private const int _RANGE = 1;
        private const int _POWER = 1;
        private readonly MapLocation _loaction;

        public Tower(MapLocation location)
        {
            _loaction = location;
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
                    invader.DecreaseHealth(_POWER);
                    break;
                }
            }
        }

    }
}