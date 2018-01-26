namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLoacation[] _path;

        public Path(MapLocation[] path)
        {
            _path = path;

        }

        public MapLocation GetLocationAt(int pathStep)
        {

            return (pathStep < _path.Length) ? (_path[pathStep]) : null; // Using Turinary operator in replace of the If Else Block



            // Using Turinary operator in replace of the If Else Block BELOW...
            //if (pathStep < _path.Length)
            //{

            //    return _path[pathStep];

            //}
            //else
            //{
            //    return null;
            //}
        }

    }
}