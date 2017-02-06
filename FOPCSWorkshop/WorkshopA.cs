using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorkshop
{
    class WorkshopA
    {
        static void Main(string[] args)
        {
            question5();
        }

        static void question5()
        {
            double input;
            Console.Write("Please enter a double: ");
            input = Convert.ToDouble(Console.ReadLine());
            while (input != -1.0)
            {
                Console.WriteLine(input.ToString("N2"));
                Console.Write("\nPlease enter a double: ");
                input = Convert.ToDouble(Console.ReadLine());
            }
        }

        static void question4()
        {
            double decimalNum;
            Console.Write("Please enter a decimal: ");
            decimalNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sq of {decimalNum} is {decimalNum * decimalNum}");
        }

        static void question3()
        {
            int number;
            Console.Write("Please enter a number: ");
            number = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The square of {number} is {number * number}");
        }

        static void question2()
        {
            string name;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Good Morning " + name);
        }

        static void question1()
        {
            string name = "Leonard Chow";
            string email = "e0167136@u.nus.edu";
            Console.WriteLine(name + "\n" + email);
        }
    }
}