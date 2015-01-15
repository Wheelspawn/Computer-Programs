using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Finite_State_Machine_3
{
    class FindFood
    {

        public static void SearchForFood()  // preceding birth, SearchForFood.findFood will tell the animal to look for food.
        {                                   // sometimes, a predator will appear if the odds are good
                                            // (or bad, from the perspective of the animal).
                Console.WriteLine("Looking for food.");

                int findFood = RandomNumber.GetRandomClass(1, 10);

                if (findFood >= 8)
                {
                    FoodFound();
                }
                else if (findFood >= 3)
                {
                    SearchForFood();
                }
                else
                {
                    Predator.PredatorFound();
                }
        }

        public static void FoodFound()
        {
            Console.WriteLine("You found some food.");

            int searchOrSleep = RandomNumber.GetRandomClass(1, 10);

            if (searchOrSleep >= 3)
            {
                FindWater.SearchForWater();
            }
            else
            {
                Console.WriteLine("You find some sleep.");
                Rest.GetSleep();
            }
        }
    }
}
