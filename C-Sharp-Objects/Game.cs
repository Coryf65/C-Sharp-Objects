using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }

            //To catch multiple exceptions the general MUST be LAST
            //and the more specific before it
            catch (OutOfBoundsException ex)//See if a range it not within the MAP
            {
                Console.WriteLine(ex.Message);
            }

            catch (TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }

            catch (Exception)//will catch all exceptions
            {
                Console.WriteLine("Unhandled Exception");
            }
        }
    }
}