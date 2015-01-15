using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haypile
{
    class Program
    {
        // a simple program that displays and integer and updates the display after a cumulative arithmetic operation.

        public static int haystack = 0;
        public static void Begin()
        {
            int randomnumber = RandomNumber.GetRandomClass(0, 5);
            Haypile.Count(randomnumber);
            ContinueLoop();
            // access ContinueLoop()
        }

        public static void ContinueLoop()
        {
            Begin();
            // go back to Begin()
        }

        static void Main(string[] args)
        {
            // program begins when Main accesses Begin();, generates a random number and sends it to Haypile.Count
            Begin();
        }
    }
}
