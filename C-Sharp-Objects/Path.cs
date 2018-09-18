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

        // Determines if a location is on the path
        public bool IsOnPath(MapLocation location)
        {
            foreach (var pathLocation in _path)
            {
                // the double equal sign checks for reference equality
                // same as using ReferenceEquals(Object, Object)
                if (location.Equals(pathLocation))
                {
                    return true;
                }
            }

            return false;
        }
    }
}