using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandBundle
{
    class Calculator
    {
        public Calculator()
        {
            string choice;
            do
            {
                Console.WriteLine("(A)dd, (M)ultiply or (D)ivide?");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "a":
                    case "add":
                    case "Add":
                        double a1;
                        double a2;
                        Console.WriteLine("Enter the first number");
                        double.TryParse(Console.ReadLine(), out a1);
                        Console.WriteLine("Enter the second number");
                        double.TryParse(Console.ReadLine(), out a2);
                        Console.WriteLine("The sum is:");
                        Console.WriteLine(a1 + a2);
                        break;

                    case "m":
                    case "multiply":
                    case "Multiply":
                        double m1;
                        double m2;
                        Console.WriteLine("Enter the first number");
                        double.TryParse(Console.ReadLine(), out m1);
                        Console.WriteLine("Enter the second number");
                        double.TryParse(Console.ReadLine(), out m2);
                        Console.WriteLine("The product is:");
                        Console.WriteLine(m1 * m2);
                        break;

                    case "d":
                    case "divide":
                    case "Divide":
                        double d1;
                        double d2;
                        Console.WriteLine("Enter the first number");
                        double.TryParse(Console.ReadLine(), out d1);
                        Console.WriteLine("Enter the second number");
                        double.TryParse(Console.ReadLine(), out d2);
                        Console.WriteLine("The quotient is:");
                        Console.WriteLine(d1 / d2);
                        break;
                    default:
                        Console.Clear();
                        continue;
                }
            } while (choice != "q");
        }
    }
}
