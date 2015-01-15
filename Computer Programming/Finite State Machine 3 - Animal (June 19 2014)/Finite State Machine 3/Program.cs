using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Finite_State_Machine_3
{
    class Program
    {

        // this program adds improvements to previous FSMs because it breaks up the methods into separate classes,
        // making the code easier to read

        static void Birth() // after being born, animal will look for food
        {
            FindFood.SearchForFood(); // leave Birth(), enter FindFood()
        }

        static void Main(string[] args) // entry point of the program
        {
            Console.WriteLine("\n   `~`~`~`~`~`~`~`~`~");
            Console.WriteLine("   `~`~  ANIMAL  `~`~");
            Console.WriteLine("   `~`~          `~`~");
            Console.WriteLine("   `~`~`~`~`~`~`~`~`~\n");
            Console.WriteLine("You are a creature.\nYou have just been born.\n");

            Birth();
        }
    }
}
