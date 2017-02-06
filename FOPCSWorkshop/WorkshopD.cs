using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorkshop
{
    class WorkshopD
    {
        static void Main(string[] args)
        {
            while (true)
            {
                question4();
            }
        }

        static void question4()
        {
            string input = "";
            double number = 0.0, guess = 0.0;
            Random random = new Random();

            Console.Write("Please enter a number: ");
            input = Console.ReadLine();
            Double.TryParse(input, out number);

            if (number == 0)
            {
                Console.WriteLine("The sqrt of {0} is 0.000\n", number);
                return;
            }

            guess = random.NextDouble() * number;

            if (guess*guess != number)
            {
                guess = (guess + (number / guess)) / 2;

                while (number - guess * guess >= 0.00001 || guess * guess - number >= 0.00001)
                {
                    guess = (guess + (number / guess)) / 2;
                }
            }

            Console.WriteLine("The sqrt of {0} is {1:0.###}\n", number, guess);

            return;
        }

        static void question3()
        {
            int attempts = 0;
            int guess = -1;
            Random random = new Random();
            int randNum = random.Next(0, 9);
            Console.WriteLine("Thinking of a new number...");

            while (guess != randNum)
            {
                Console.Write("Guess the number I am thinking: ");
                if (!(Int32.TryParse(Console.ReadLine(), out guess)))
                {
                    Console.WriteLine("Not a number!\n");
                    continue;
                }
                if (guess != randNum) Console.WriteLine("Wrong!");
                attempts++;
            }

            Console.WriteLine("Congrats! I was thinking of {0}, and you guessed {1}, in {2} attempts!", randNum, guess, attempts);
            if (attempts <= 2)
            {
                Console.WriteLine("You are a Wizard!");
            } else if (attempts == 3)
            {
                Console.WriteLine("You are a good guess.");
            } else
            {
                Console.WriteLine("You are lousy!");
            }

            Console.WriteLine("Try again\n");
        }

        static void question2()
        {
            int a, b, lcm, factor;
            string input;
            string[] splitInput;

            Console.Write("Please enter 2 numbers: ");
            input = Console.ReadLine();

            splitInput = input.Split(' ');

            Int32.TryParse(splitInput[0], out a);
            Int32.TryParse(splitInput[1], out b);

            factor = a * b;

            while (a != b)
            {
                if (a < b)
                {
                    b = b - a;
                } else
                {
                    a = a - b;
                }
            }

            lcm = factor / a;

            Console.WriteLine("The LCM is {0}\n", lcm);
           
        }

        static void question1()
        {
            int input=0;

            while (input != 88)
            {
                Console.Write("Please enter an integer: ");
                Int32.TryParse(Console.ReadLine(), out input);
            }

            Console.WriteLine("Lucky you...");
        }
    }
}
