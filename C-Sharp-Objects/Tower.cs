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

            /*
             * Using a While vs a For loop
             */

            //int index = 0;

            //while (index < invaders.Length)
            //{
            //    Invader invader = invaders[index];
            //    // Do stuff with the invader

            //    index++;
            //}


            // similar to a while loop
            //for (int i = 0; i < invaders.Length; i++)
            //{
            //    Invader invader = invaders[i];
            //    // Do Stuff
            //}

            //loop through each item in the collection
            foreach (Invader invader in invaders)
            {
                // Do stuff
            }
        }

    }
}