using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Finite_State_Machine_3
{
    class Rest
    {
        public static void GetSleep()
        {
            int decideToWake = RandomNumber.GetRandomClass(1, 10);

            if (decideToWake >= 7)
            {
                Console.WriteLine("Sleeping.");
                GetSleep();
            }
            else
            {
                WakeUp();
            }
        }

        public static void WakeUp()
        {
            Console.WriteLine("You've woken up.");

            int findFoodOrWater = RandomNumber.GetRandomClass(1, 3);

            if (findFoodOrWater == 2)
            {
                FindWater.SearchForWater();
            }
            else
            {
                FindFood.SearchForFood();
            }
        }
    }
}
