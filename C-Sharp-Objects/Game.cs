using System;

namespace C_Sharp_Objects
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new[] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );               

            }

            //To catch multiple exceptions the general MUST be LAST
            //and the more specific before it
            catch (OutOfBoundsException ex)//See if a range it not within the MAP
            {
                Console.WriteLine(ex.Message);
            }

            catch (C_Sharp_ObjectsException)
            {
                Console.WriteLine("Unhandled C_Sharp_ObjectsException");
            }

            catch (Exception ex)//will catch all exceptions
            {
                Console.WriteLine("Unhandled Exception" + ex);
            }
        }
    }
}