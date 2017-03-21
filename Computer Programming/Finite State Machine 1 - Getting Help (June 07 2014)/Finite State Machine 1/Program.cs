using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Finite_State_Machine
{
    class Program
    {
        // Finite State Machine that emulates human behavior by going through a series of states,
        // with an element of randomness to simulate uncertainty.

        static void CanSeePlayer()
        {
            Thread.Sleep(500);
            Console.WriteLine("I can see the enemy!");
            PlayerIsFound();
        }

        static void CannotSeePlayer()
        {
            Thread.Sleep(500);
            Console.WriteLine("I can't see the enemy!");
            Random random = new Random();
            int seeChance = random.Next(1, 10);
            if (seeChance >= 5)
            {
                CanSeePlayer();
            }
            else
            {
                CannotSeePlayer();
            }
        }

        static void PlayerIsFound()
        {
            Thread.Sleep(500);
            Console.WriteLine("I found the enemy!");
            CanFight();
        }

        static void CanFight()
        {
            Thread.Sleep(500);
            Random random = new Random();
            int fightChance = random.Next(1, 10);
            if (fightChance >= 5)
            {
                FindAllies();
            }
            else
            {
                RunAway();
            }
        }

        static void FindAllies()
        {
            Thread.Sleep(500);
            Console.WriteLine("I'm going to get help!");
        }

        static void RunAway()
        {
            Thread.Sleep(500);
            Console.WriteLine("I'm going to run away!");
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int findChance = random.Next(1, 10);
            if (findChance >= 5)
            {
                CanSeePlayer();
            }
            else
            {
                CannotSeePlayer();
            }
        }
    }
}
