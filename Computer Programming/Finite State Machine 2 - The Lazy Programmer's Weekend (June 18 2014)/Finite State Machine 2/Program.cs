using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Finite_State_Machine_2
{
    class Program
    {
        static int GetRandomClass(int a, int b)
        {
            // GetRandomClass is the method that gives all of the other methods random integers.
            // Due to the fact that the pseudorandom number generator uses the PC's clock to get its numbers, it has to sleep for a
            // few milliseconds to avoid choosing the same numbers twice.
            // Instead of the methods having to declare the Random class every time they want a random number, they now only have to
            // declare the integers and their ranges.
            Random random = new Random();
            Thread.Sleep(1000);
            int numberRandom = random.Next(a, b);
            Thread.Sleep(1000);
            return numberRandom;
        }

        static void GoUpstairs()
        {
            Console.WriteLine("Going upstairs");

            int findThing = GetRandomClass(1, 6);

            if (findThing == 1)
            {
                Console.WriteLine("I'm going to sleep.");
                GoToSleep();
            }
            else if (findThing == 2)
            {
                Console.WriteLine("I'm going to clean the attic.");
            }
            else
            {
                Console.WriteLine("I'm going to use the computer.");

                int findWebsite = GetRandomClass(1, 4);

                if (findWebsite == 1)
                {
                    Console.WriteLine("I'm going to look up the news.");
                }
                else if (findWebsite == 2)
                {
                    Console.WriteLine("I'm going to play a game.");
                }
                else
                {
                    Console.WriteLine("I'm going to shop online.");
                }
            }
            GoDownstairs();
        }

        static void GoToLivingRoom()
        {
            Console.WriteLine("Going to living room.");

            int findThing = GetRandomClass(1, 4);

            if (findThing == 1)
            {
                Console.WriteLine("I'm going to read a book.");
            }
            else if (findThing == 2)
            {
                Console.WriteLine("I'm going to watch a movie.");
            }
            else
            {
                Console.WriteLine("I'm going to sleep.");
            }
            GoToSleep();
        }
        
        static void GoToKitchen()
        {
            Console.WriteLine("Going to the kitchen.");

            int makeFood = GetRandomClass(1, 4);

            if (makeFood == 1)
            {
                Console.WriteLine("I'm going to make myself a pot of steaming coffee.");
            }
            else if (makeFood == 2)
            {
                Console.WriteLine("I'm going to make myself a piece of toast.");
            }
            else
            {
                Console.WriteLine("I'm going to cook a stew.");
            }
            TakeShower();
        }

        static void GoDownstairs()
        {
            Console.WriteLine("Going downstairs.");

            int findThing = GetRandomClass(1, 2);

            if (findThing == 1)
            {
                int timesWorkedOut = 0;
                Console.WriteLine("I'm going to work out with my weights.");
                do
                {
                    Console.WriteLine("Working out.");
                    timesWorkedOut++;
                } while (timesWorkedOut >= 3);
                TakeShower();
            }
            else
            {
                Console.WriteLine("I'm going to do the laundry.");

                int waiting = 0;
                do
                {
                    Console.WriteLine("Waiting.");
                    waiting++;
                } while (waiting >= 3);
            }
            GoUpstairs();
        }

        static void TakeShower()
        {
            Console.WriteLine("I'm going take a shower.");
            GoToSleep();
        }

        static void GoToSleep()
        {
            int hoursSlept = 0;
            Console.WriteLine("I'm going take a nap.");
            do
            {
                Console.WriteLine("Sleeping.");
                hoursSlept++;
            } while (hoursSlept >= 8);

            int end = 0;

            do
            {
                end++;
                WakeUp();
            } while (end >= 3);
            Console.WriteLine("End.");
        }

        static void WakeUp()
        {
            Thread.Sleep(500);
            Console.WriteLine("Waking up.");
            int goToPlace = GetRandomClass(1, 5);

            {
                if (goToPlace == 4)
                {
                    GoUpstairs();
                }
                else if (goToPlace == 3)
                {
                    GoToLivingRoom();
                }
                else if (goToPlace == 2)
                {
                    GoToKitchen();
                }
                else
                {
                    GoDownstairs();
                } // end if
            }
        }

        static void Main(string[] args) // The entry point of the program.
        {
            Console.WriteLine("\n   ~~~~~~ The Lazy Programmer's Weekend ~~~~~~\n\n");
            WakeUp();
        } // end main
    }
}