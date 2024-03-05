using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool startGame;

            Console.WriteLine("Want guess a number? +/-");
            startGame = Console.ReadLine() == "+";

            if (!startGame) { return; }

            var rng = new Random(0);

            int number = Convert.ToInt32(rng.Next(0, 100));

            Console.WriteLine("I made a number from 0 to 100.");

            while (true)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("Smaller.");
                }
                else if (guess < number) {
                    Console.WriteLine("Bigger.");
                }
                else
                {
                    Console.WriteLine("You guess it!");
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}
