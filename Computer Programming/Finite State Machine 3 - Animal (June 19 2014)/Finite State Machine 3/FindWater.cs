using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Finite_State_Machine_3
{
    class FindWater
    {
        public static void SearchForWater()
        {
                Console.WriteLine("Looking for water.");

                int findWater = RandomNumber.GetRandomClass(1, 10);

                if (findWater >= 8)
                {
                    WaterFound();
                }
                else if (findWater >= 3)
                {
                    SearchForWater();
                }
                else
                {
                    Predator.PredatorFound();
                }
        }

        public static void WaterFound()
        {
            Console.WriteLine("You found a spring.");

            int searchOrSleep = RandomNumber.GetRandomClass(1, 10);

            if (searchOrSleep >= 3)
            {
                FindFood.SearchForFood();
            }
            else
            {
                Console.WriteLine("You find some sleep.");
                Rest.GetSleep();
            }
        }
    }
}
