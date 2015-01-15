using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BeachCloser
{
    public class Program
    {
        public Program()
        {
            Console.Write(@"Welcome to the Great Lakes beach closing simulator.

The purpose of the simulator is to use numbers to simulate a random day at the  beach and the effects of the environment that could close it.
MPN stands for Most Probable Number and it is the amount of bacteria estimated  to be in one hundred milliliters of water.
When the amount is determined to be too high, the beach can close. 999 per 100  milliliters is the amount of microbes that can initiate a beach closing.
Blue green algae can also cause a beach closing because it is hazardous when consumed.

");
            int daynumber = 1;
            string choice;
            do
            {
                Random random = new Random();
                int population = random.Next(20, 150);
                int algaechance = random.Next(1, 13);
                int mpn = random.Next(200, 1100);
                int temperature = random.Next(60, 110);
                int cloudcoverage = random.Next(1, 10);
                Console.WriteLine("Today is day " + daynumber++ + ".");
                Console.WriteLine("Today's temperature equals: " + temperature);
                Console.WriteLine("There are " + population + " people on the beach.");
                Console.WriteLine("The MPN conditions are: " + mpn + "/100 mL of water.");

                if (cloudcoverage == 1)
                {
                    Console.WriteLine("The skies are cloudless.");
                }
                else if (cloudcoverage == 2)
                {
                    Console.WriteLine("The skies have broken clouds.");
                }
                else if ((cloudcoverage >= 3) & (cloudcoverage <= 6))
                {
                    Console.WriteLine("The sky has moderate cloud coverage.");
                }
                else if (cloudcoverage == 7)
                {
                    Console.WriteLine("The skies are overcast.");
                }
                else if (cloudcoverage == 8)
                {
                    Console.WriteLine("A mild thunderstorm begins to take place.");
                }
                else if (cloudcoverage == 9)
                {
                    Console.WriteLine("A thunderstorm is taking place, causing rain and lightning.");
                }
                else
                {
                    Console.WriteLine("The skies have broken clouds.");
                }

                if (mpn > 999)
                {
                    Console.WriteLine("E. Coli has reached a high enough level to initiate a beach closing.");
                }

                if ((mpn < 999) & (mpn > 700))
                {
                    Console.WriteLine("E. Coli has reached a level that has caused an advisory warning.");
                }

                if (algaechance > 11)
                {
                    Console.WriteLine("Blue green algae has been spotted along the coasts and has caused a beach closing.");
                }

                choice = Console.ReadLine();
            } while (choice != "Q");
        }
    }
}
