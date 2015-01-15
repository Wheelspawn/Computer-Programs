using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Haypile
{
    class RandomNumber
    {
        public static int GetRandomClass(int a, int b)
        {
            // GetRandomClass is the method that gives all of the other methods random integers.
            // Due to the fact that the pseudorandom number generator uses the PC's clock to get its numbers, it has to sleep for a
            // few milliseconds to avoid choosing the same numbers twice.
            // Instead of the methods having to declare the Random class every time they want a random number, they now only have to
            // declare the integers and their ranges.
            Random random = new Random();
            int numberRandom = random.Next(a, b);
            Thread.Sleep(1000);      // changing this number will also change the rate at which new messages appear in the window.
            return numberRandom;
        }
    }
}