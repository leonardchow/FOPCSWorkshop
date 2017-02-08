using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorkshop
{
    class WorkshopMoreExamples
    {
        static void Main()
        {
            do
            {
                arraysHistogram();
            } while (true);
        }

        static void arraysHistogram()
        {
            int[] intArr = new int[10];
            Random random = new Random();
            int rNum = 0;

            for (int i = 0; i < 50; i++)
            {
                rNum = random.Next(0, 10); // 0..9
                intArr[rNum]++;
            }

            Console.WriteLine("Number");

            for (int j = 0; j < 10; j++)
            {
                Console.Write("  {0}\t", j);

                for (int k = 0; k < intArr[j]; k++) // Print stars
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Write("Press enter to repeat...");
            Console.ReadLine();
            Console.WriteLine();

            return;
        }

        static void arraysNumbers()
        {
            int[] intArr = new int[10];
            Random random = new Random();
            int rNum = 0;

            for (int i = 0; i < 50; i++)
            {
                rNum = random.Next(0, 10); // 0..9
                intArr[rNum]++;
            }

            Console.WriteLine("Number\tCount");

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("  {0}\t  {1}", j, intArr[j]);
            }

            Console.Write("Press enter to repeat...");
            Console.ReadLine();
            Console.WriteLine();

            return;
        }

        static void Coins()
        {
            string input = "";
            int dollars = 0, cents = 0;

            int coin100 = 0;
            int coin50 = 0, coin20 = 0;
            int coin10 = 0, coin5 = 0;

            Console.WriteLine("Coins problem");
            Console.Write("Please input an amount: e.g. $$.$$: ");

            input = Console.ReadLine();
            int.TryParse(input.Split('.')[0], out dollars);
            int.TryParse(input.Split('.')[1], out cents);

            if (cents != 0)
            {
                if (cents >= 50) // Max is 95
                {
                    cents -= 50;
                    coin50++;
                }
                while (cents >= 20) // Max is 45
                {
                    cents -= 20;
                    coin20++;
                }
                while (cents >= 10) // Max is 15
                {
                    cents -= 10;
                    coin10++;
                }
                while (cents >= 5) // Max is 5
                {
                    cents -= 5;
                    coin5++;
                }
            }

            coin100 = dollars;

            Console.WriteLine("Dollars\t{0}", coin100);
            Console.WriteLine("50 C\t{0}", coin50);
            Console.WriteLine("20 C\t{0}", coin20);
            Console.WriteLine("10 C\t{0}", coin10);
            Console.WriteLine("5 C\t{0}", coin5);

            int total = 50 * coin50 + 20 * coin20 + 10 * coin10 + 5 * coin5;

            Console.WriteLine("Total: ${0}.{1:00}", coin100, total);

            return;
        }
    }
}
