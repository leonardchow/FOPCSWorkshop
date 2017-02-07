using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorkshop
{
    class WorkshopB
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while(keepRunning)
            {
                keepRunning = question10();
            }
        }

        static bool question10()
        {
            double a, b, c, s, area;
            Console.Write("Please enter A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter C: ");
            c = Convert.ToDouble(Console.ReadLine());

            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine(area);

            return true;
        }

        static bool question9()
        {
            double FIXED_CHARGE = 2.40;
            double RATE = 0.4;
            double kms, result;

            Console.Write("Please enter distance in km: ");
            if (!(Double.TryParse(Console.ReadLine(), out kms)))
            {
                Console.WriteLine("Couldn't parse input");
                return false;
            }

            result = FIXED_CHARGE + (kms * RATE);
            result *= 10;
            result = Math.Ceiling(result);
            result /= 10;
            Console.WriteLine("{0:0.0}\n", result);

            return true;
        }

        static bool question8()
        {
            double FIXED_CHARGE = 2.40;
            double RATE = 0.4;
            double kms, result;
            double roundedFare;

            Console.Write("Please enter distance in km: ");
            if (!(Double.TryParse(Console.ReadLine(), out kms)))
            {
                Console.WriteLine("Couldn't parse input");
                return false;
            }

            result = FIXED_CHARGE + (kms * RATE);
            roundedFare = Math.Round(result, 1);
            Console.WriteLine("{0:0.00}\n", roundedFare);

            return true;
        }

        static bool question7()
        {
            double FIXED_CHARGE = 2.40;
            double RATE = 0.4;
            double kms, result;

            Console.Write("Please enter distance in km: ");
            if (!(Double.TryParse(Console.ReadLine(), out kms)))
            {
                Console.WriteLine("Couldn't parse input");
                return false;
            }

            result = FIXED_CHARGE + (kms * RATE);
            Console.WriteLine(result + "\n");

            return true;
        }

        static bool question6()
        {
            int x1, x2, y1, y2;
            double dist;
            Console.Write("Please enter x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            dist = Math.Sqrt ( Math.Pow( (x2 - x1) , 2) + Math.Pow( (y2 - y1) , 2) );

            Console.WriteLine("{0:g}\n", dist);

            return true;
        }

        static bool question5()
        {
            double x, y;

            Console.Write("Please enter a number: ");
            if (!(Double.TryParse(Console.ReadLine(), out x)) )
            {
                Console.WriteLine("Couldn't parse input");
                return false;
            }

            y = (5 * Math.Pow(x, 2)) - (4 * x) + 3 - 3*x*x;
            Console.WriteLine(x);
            Console.WriteLine("{0:0\n}", y);

            return true;
        }

        static bool question4()
        {
            string input;
            double temp, output;

            Console.Write("Please enter temperature in C: ");

            input = Console.ReadLine();

            if (input == "exit") return false;

            Double.TryParse(input, out temp);

            output = 1.8 * temp + 32;
            Console.WriteLine("{0:0\n}", output);

            return true;
        }
        
        static bool question3()
        {
            double input, output, hAllow, tAllow;
            Console.Write("Please enter salary: ");
            Double.TryParse(Console.ReadLine(), out input);

            if (input == -1.0) return false;

            hAllow = input * 0.1;
            tAllow = input * 0.03;

            output = input + hAllow + tAllow;
            Console.WriteLine("{0:c}\n", output);

            return true;
        }

        static bool question2()
        {
            double input;
            Console.Write("Please enter a double: ");
            Double.TryParse(Console.ReadLine(), out input);

            if (input == -1.0) return false;

            input = Math.Sqrt(input);
            Console.WriteLine("{0:##0.000\n}", input);

            return true;
        }

        static bool question1()
        {
            double input;
            Console.Write("Please enter a double: ");
            Double.TryParse(Console.ReadLine(), out input);

            if (input == -1.0) return false;

            input = Math.Sqrt(input);
            Console.WriteLine("{0:##0.###\n}", input);

            return true;
        }
    }
}
