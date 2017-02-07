using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorkshop
{
    class WorkshopE
    {
        static void Main()
        {
            while (!true)
            {
                //question5();
            }
            question6();
            //question5();
            //question2();
        }

        static void question6()
        {
            bool isPerfect;
            int sum;
            List<int> factors = new List<int>();

            for (int j = 1; j <= 1000; j++)
            {
                isPerfect = false;
                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        factors.Add(i);
                    }
                }

                sum = factors.Sum();

                if (sum == j)
                {
                    isPerfect = true;
                }

                if (isPerfect) Console.Write("{0}\t", j);

                // Clear List of factors:
                factors.Clear();
            }

            Console.WriteLine("\nDone.");

            return;
        }

        static void question5()
        {
            bool isPrime;

            for (int j = 5; j <= 10000; j++)
            {
                isPrime = true;
                for (int i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write("{0}\t", j);
                }
            }
            Console.WriteLine("\nDone.");

            return;
        }

        static void question4()
        {
            string input;
            bool isPerfect = false;
            int number, sum;
            List<int> factors = new List<int>();

            Console.Write("Please enter a number: ");
            input = Console.ReadLine();
            Int32.TryParse(input, out number);

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }
            }

            sum = factors.Sum();

            if (sum == number)
            {
                isPerfect = true;
            }

            Console.WriteLine(isPerfect ? "Perfect" : "Not Perfect");

            return;
        }

        static void question3()
        {
            string input;
            int number;
            bool isPrime = true;

            Console.Write("Please enter a number: ");
            input = Console.ReadLine();
            Int32.TryParse(input, out number);

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? "Prime" : "Not Prime");
        }

        static void question2()
        {
            q2PrintHeader();

            double inverse, sqrt, sq;

            for (int i = 1; i <= 10; i++)
            {
                inverse = 1.0 / i;
                sqrt = Math.Sqrt(i);
                sq = Math.Pow(i, 2);
                Console.WriteLine("{0:0.0}\t\t {1:0.0##}\t\t  {2:0.0##}\t\t {3:0.0}", i, inverse, sqrt, sq);
            }

            return;
        }

        static void q2PrintHeader()
        {
            Console.WriteLine(" NO\t\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            for (int i = 0; i < 55; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");
        }

        static void question1b()
        {
            // Factorial using decrement
            string input;
            int number, factorial = 1;

            Console.Write("Please enter a number: ");
            input = Console.ReadLine();
            Int32.TryParse(input, out number);

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

            return;
        }
        
        static void question1a()
        {
            // Factorial using increment
            string input;
            int number, factorial = 1;

            Console.Write("Please enter a number: ");
            input = Console.ReadLine();
            Int32.TryParse(input, out number);

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

            return;
        }
    }
}
