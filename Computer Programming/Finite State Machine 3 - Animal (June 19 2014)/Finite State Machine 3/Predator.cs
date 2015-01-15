using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Finite_State_Machine_3
{
    class Predator
    {
        public static void PredatorFound()
        {
            Console.WriteLine("There's a predator nearby!");

            int runAway = RandomNumber.GetRandomClass(1, 10);

            if (runAway >= 3)
            {
                Console.WriteLine("You ran away.");

                Console.WriteLine("You find some sleep.");
                Rest.GetSleep();
            }
            else
            {
                Console.WriteLine("You have been eaten! Game over.");
            }
        }
    }
}
