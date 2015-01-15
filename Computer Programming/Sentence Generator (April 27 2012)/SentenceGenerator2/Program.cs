using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // A simple sentence generator that randomly selects strings from arrays of nouns and verbs.

            /* The program will close if the sequence "f*" is entered at the first 'Console.ReadLine'.
             */
            string x;
            Console.WriteLine("Press any key to start:");
            x = Console.ReadLine();

            Random rng = new Random();

            do
            {
                //Rng generates 3 series of numbers.
                int n;
                n = rng.Next(0, 30);
                string[] names = { "Grace ", "Ryan ", "Taylor ", "Nathaniel ", "Shammy ", "Jonathan ", "Ebyn ", "Kevin ", "Carl Sagan ", "Romeo ", "Jude ", "Spock ", "Michael ", "John ", "Darth Vader ", "Aragorn ", "Billy Bob Joel ", "Bo ", "Rad ", "Jimbo ", "Bill ", "Waldo ", "Vladislav ", "Tommy ", "Moses ", "Herb ", "Dunneback ", "Rick ", "Deborah ", "I "};

                int v;
                v = rng.Next(0, 22);
                string[] verbs = { "played a game with ", "argued with ", "phasered ", "gave a gun to ", "tried to assassinate ", "moved ", "insulted ", "pondered over the existence of ", "fired ", "tempted ", "killed ", "tried to bribe ", "ate ", "touched ", "saw ", "talked to ", "brazed ", "threw a stone at ", "challenged ", "tickled ", "slapped ", "gave a dollar to " };

                int o;
                o = rng.Next(0, 23);
                string[] objects = { "Richard ", "Alan Turing ", "a man in an asparagus costume ", "a knight ", "The Doctor ", "a zergling ", "a borg ", "a programmer ", "his time machine ", "a man ", "a lion ", "a box ", "a wall ", "a stone ", "a machine ", "a pill ", "a fruit", "a zombie ", "a cat ", "a cornflake ", "a mugger ", "Mr. Orange ", "Sherlock Holmes " };

                /*The random n/v/o values allow the generation of 10,648 sentence types.
                */
                Thread.Sleep(15);
                Console.WriteLine(names[n] + verbs[v] + objects[o]);
                Console.ReadLine();
            }
            while (x != "f*");
        }
    }
}