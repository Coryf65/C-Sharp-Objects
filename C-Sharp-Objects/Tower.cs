namespace C_Sharp_Objects
{
    class Tower
    {

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
                if (invader.IsActive && _loaction.InRangeOf(invader.Location, 1))
                {
                    invader.DecreaseHealth(1);
                    break;
                }
            }
        }

    }
}