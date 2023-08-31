using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturIfElseWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Skriv inn en temperatur: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int temperature))
                {
                    if (temperature > 0)
                    {
                        Console.WriteLine("Temperaturen er plussgrader.");
                    }
                    else if (temperature < 0)
                    {
                        Console.WriteLine("Temperaturen er minusgrader.");
                    }
                    else
                    {
                        Console.WriteLine("Temperaturen er null.");
                    }
                }
                else
                {
                    Console.WriteLine("Ugyldig, skriv inn et tall");
                }
            }
                Console.ReadLine();
        }
    }
}