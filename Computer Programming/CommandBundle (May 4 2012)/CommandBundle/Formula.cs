using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandBundle
{
    class Formula
    {
        public Formula()
        {
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Select formula:");
                Console.WriteLine("Formula for (w)ork");
                Console.WriteLine("Formula for (f)orce");
                Console.WriteLine("Formula for m(o)mentum");
                Console.WriteLine("Formula for (m)ass");
                Console.WriteLine("Formula for (p)ower");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "W":
                    case "w":
                        double work;
                        double distance;
                        Console.WriteLine("What is the work?");
                        double.TryParse(Console.ReadLine(), out work);
                        Console.WriteLine("What is the distance?");
                        double.TryParse(Console.ReadLine(), out distance);
                        Console.WriteLine("The work is:");
                        Console.WriteLine(work * distance);
                        break;

                    case "F":
                    case "f":
                        double mass;
                        double acceleration;
                        Console.WriteLine("What is the mass?");
                        double.TryParse(Console.ReadLine(), out mass);
                        Console.WriteLine("What is the acceleration?");
                        double.TryParse(Console.ReadLine(), out acceleration);
                        Console.WriteLine("The force is:");
                        Console.WriteLine(mass * acceleration);
                        break;

                    case "O":
                    case "o":
                        double velocity;
                        Console.WriteLine("What is the mass?");
                        double.TryParse(Console.ReadLine(), out mass);
                        Console.WriteLine("What is the velocity?");
                        double.TryParse(Console.ReadLine(), out velocity);
                        Console.WriteLine("The momentum is:");
                        Console.WriteLine(mass * velocity);
                        break;

                    case "M":
                    case "m":
                        double force;
                        Console.WriteLine("What is the force?");
                        double.TryParse(Console.ReadLine(), out force);
                        Console.WriteLine("What is the acceleration?");
                        double.TryParse(Console.ReadLine(), out acceleration);
                        Console.WriteLine("The mass is");
                        Console.WriteLine(force / acceleration);
                        break;

                    case "P":
                    case "p":
                        double time;
                        Console.WriteLine("What is the time?");
                        double.TryParse(Console.ReadLine(), out time);
                        Console.WriteLine("What is the work?");
                        double.TryParse(Console.ReadLine(), out work);
                        Console.WriteLine("The power is");
                        Console.WriteLine(work / time);
                        break;

                    default:
                        Console.ReadLine();
                        break;
                }
            } while (choice != "q");
        }
    }
}
