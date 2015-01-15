using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandBundle
{
    class MainMenu
    {
        public MainMenu()
        {
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Welcome to the CLpackage menu. Select an application.");
                Console.WriteLine("Text processor");
                Console.WriteLine("Calculator");
                Console.WriteLine("Converter");
                Console.WriteLine("");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "T":
                    case "t":
                    case "text":
                    case "Text":
                    case "text processor":
                    case "Text processor":
                        TextProcess textprocess = new TextProcess();
                        break;

                    case "C":
                    case "c":
                    case "converter":
                    case "Converter":
                        Converter converter = new Converter();
                        break;

                    case "calc":
                    case "Calc":
                    case "calculator":
                    case "Calculator":
                    case "calculate":
                        Calculator calculator = new Calculator();
                        break;
                    default:
                        Console.Clear();
                        continue;
                }
            } while (choice != "q");
        }
    }
}