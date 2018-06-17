namespace C_Sharp_Objects
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;

        }

        public MapLocation GetLocationAt(int pathStep)
        {

            // Using Turinary operator in replace of the If Else Block
            return (pathStep < _path.Length) ? _path[pathStep] : null; 

        }

    }
}