using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandBundle
{
    class Currency
    {
        public Currency()
        {
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Convert dollars to (Y)en, or dollars to (E)uros?");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "E":
                    case "e":
                        double euroconvert;
                        Console.WriteLine("What is your amount?");
                        double.TryParse(Console.ReadLine(), out euroconvert);
                        Console.WriteLine(euroconvert * .7608 + " euros");
                        break;

                    case "Y":
                    case "y":
                        double yenconvert;
                        Console.WriteLine("What is your amount?");
                        double.TryParse(Console.ReadLine(), out yenconvert);
                        Console.WriteLine(yenconvert * 81.25 + " yen");
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (choice != "q");
        }
    }
}
