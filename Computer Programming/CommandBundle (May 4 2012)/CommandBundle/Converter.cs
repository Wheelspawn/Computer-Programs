using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandBundle
{
    class Converter
    {
        public Converter()
        {
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Compute (f)ormulas or convert (c)urrency?");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "C":
                    case "c":
                    case "convert":
                    case "Convert":
                    case "Currency":
                        Currency currency = new Currency();
                        break;

                    case "F":
                    case "f":
                    case "Formula":
                    case "formula":
                    case "formulas":
                        Formula formula = new Formula();
                        break;
                    default:
                        Console.Clear();
                        continue;
                }
            } while (choice != "q");
        }
    }
}
