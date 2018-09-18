using System;

namespace C_Sharp_Objects
{
    class Point
    {
        public readonly int X;
        public readonly int Y;
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // overriding the to string method
        public override string ToString()
        {
            return X + "," + Y;
        }

        /// <summary>
        /// Checks if the object is reffering to the same coordinates on the map
        /// </summary>
        /// <param name="obj">an object</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Point))
            {
                // obj passed in is not a point | is null
                return false;
            }

            // cast to a point
            Point that = obj as Point;

            // obj does refer to coordinates
            return this.X == that.X && this.Y == that.Y;
        }

        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
        }
        
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}