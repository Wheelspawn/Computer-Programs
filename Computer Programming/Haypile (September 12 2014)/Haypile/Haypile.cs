using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haypile
{
    public class Haypile
    {
        // the Count method takes the int 'straws' and performs arithmetic on it, adding a randomly generated number to it
        public static int straws = 0;
        public static int Count(int a)
        {
            straws += a;
            Console.Clear();

            if (straws <= 1)
            {
                Console.WriteLine("Hay: " + straws + " straw");
            }
            else
            {
                Console.WriteLine("Hay: " + straws + " straws");
            }
            return straws;
        }
    }
}
