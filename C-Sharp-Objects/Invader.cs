namespace TreehouseDefense
{
    class Invader
    {

        private MapLocation _location;

        //// Methods
        //// Getter
        //public MapLoaction GetLocation()
        //{
        //    return _loaction;
        //}
        
        //// Setter 
        //public void SetLocation(MapLocation value)
        //{
        //    _locaiton = value;
        //}

        // Properties -- use encapsulation they are preffered getter and setter styles
        public MapLocation Loacation
        {
            // Getter
            get
            {
                return _location;
            }

            // Setter
            set
            {
                _location = value;
            }
        }
    }
}