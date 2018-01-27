namespace TreehouseDefense
{
    class Invader
    {

        private MapLocation _location;

        // Shorthanded way vs the whole other way
        public MapLocation Location { get; private set; }
        

        
        //// Properties -- use encapsulation they are preffered getter and setter styles
        //public MapLocation Loacation
        //{
        //    // Getter
        //    get
        //    {
        //        return _location;
        //    }

        //    // Setter
        //    // Common to have a private setter not a private getter
        //    private set
        //    {
        //        _location = value;
        //    }
        //}
    }
}