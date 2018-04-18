using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Game
    {
        static void Main(string[] args)
        {

            Map map = new Map(8, 5);

            try
            {
                MapLocation maplocation = new MapLocation(20, 20, map);
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreeHouseDefenseException)
            {
                Console.WriteLine("Unhandled TreeHouseDefenseException");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }
        }
    }
}
