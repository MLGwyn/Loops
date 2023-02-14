using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("Doing Something");

                counter++;
            }

            for (var forCounter = 0; forCounter < 4; forCounter++)
            {
                Console.WriteLine("Doing Something else");
            }

            var names = new List<string>() { "Mark", "Paula", "Sandy" };

            names.Add("Gavin");
            names.Add("Jason");
            names.Add("Terri");

            Console.Write("What is your name? ");
            var name = Console.ReadLine();

            names.Add(name);

            while (name != "quit")
            {
                Console.WriteLine($"  --{names.Count} People--  ");
                // for (var index = 0; index < names.Count; index++)
                // {
                //     var currentName = names[index];
                //     Console.WriteLine(currentName);
                // }
                for (var index = names.Count - 1; index >= 0; index--)
                {
                    var currentName = names[index];
                    Console.WriteLine($"The person at {index} is {currentName}");
                }
                // names.Reverse();
                // foreach (var currentName in names)
                // {
                //     Console.WriteLine(currentName);
                // }

                Console.WriteLine();

                Console.Write("What is your name? ");
                name = Console.ReadLine();
                names.Add(name);
            }

        }
    }
}
