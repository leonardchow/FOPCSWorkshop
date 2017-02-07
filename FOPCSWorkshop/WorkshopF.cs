using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorkshop
{
    class WorkshopF
    {
        static void Main(string[] args)
        {
            question3();
        }

        static void question3()
        {
            // Example for multidimensional array

            int[][] Marks = new int[12][];
            Marks[0] =  new int[4] { 56, 84, 68, 29};
            Marks[1] =  new int[4] { 94, 73, 31, 96 };
            Marks[2] =  new int[4] { 41, 63, 36, 90 };
            Marks[3] =  new int[4] { 99,  9, 18, 17 };
            Marks[4] =  new int[4] { 62,  3, 65, 75 };
            Marks[5] =  new int[4] { 40, 96, 53, 23 };
            Marks[6] =  new int[4] { 81, 15, 27, 30 };
            Marks[7] =  new int[4] { 21, 70,100, 22 };
            Marks[8] =  new int[4] { 88, 50, 13, 12 };
            Marks[9] =  new int[4] { 48, 54, 52, 78 };
            Marks[10] = new int[4] { 64, 71, 67, 25 };
            Marks[11] = new int[4] { 16, 93, 46, 72 };

            double[] Avg = new double[12];

            // Calculate student average
            for (int i = 0; i < 12; i++)
            {
                double avg = 0.0;

                for (int k = 0; k < 4; k++)
                {
                    avg += Marks[i][k];
                }

                Avg[i] = avg / 4;
                //Console.WriteLine(Avg[i]);
            }

            // Calculate subject average
            Console.WriteLine("Average per subject:");

            for (int m = 0; m < 4; m++)
            {
                double subAvg = 0.0;
                for (int j = 0; j < 12; j++)
                {
                    subAvg += Marks[j][m];
                }

                subAvg /= 12;
                Console.Write("{0:0.00000}\t", subAvg);
            }

            Console.WriteLine();

            return;
        }

        static void question2()
        {
            int initNum = 20, swap, num;
            Random random = new Random();

            //int[] numbers = { 1, 3, 2, 7, 8, 6, 5, 4, 0, 9, 15, 14, 11, 13, 12 };

            //Fill array with unique random numbers
            int[] numbers = new int[initNum];
            int[] appeared = new int[initNum];
            for (int i = 0; i < initNum; i++)
            {
                num = random.Next(0, initNum);
                while (appeared[num] != 0)
                {
                    num = random.Next(0, initNum);
                }
                appeared[num] += 1;
                numbers[i] = num;
            }
            Console.WriteLine("Array:");
            printIntArray(numbers);
            Console.WriteLine();

            // Bubble sort
            for (int i = 0; i < initNum; i++)
            {
                for (int j = i + 1; j < initNum; j++)
                {
                    if (numbers[j] >= numbers[i])
                    {
                        swap = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = swap;
                    }
                    // Print array
                    printIntArray(numbers);
                }
            }
        }

        static void printIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }

        static void question1()
        {
            string input;
            int[] Sales = new int[12];
            string[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int max=0, min=-1, maxMonth=0, minMonth=0;
            int avg = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.Write("Please enter the sales for {0}: ", Months[i]);
                input = Console.ReadLine();
                Int32.TryParse(input, out Sales[i]);

                if (Sales[i] > max)
                {
                    max = Sales[i];
                    maxMonth = i;
                }
                if (Sales[i] < min || min == -1)
                {
                    min = Sales[i];
                    minMonth = i;
                }
                avg += Sales[i];
            }

            // Calculate average:
            avg /= 12;

            Console.WriteLine("Maximum sales: {0}, during {1}", Sales[maxMonth], Months[maxMonth]);
            Console.WriteLine("Minimum sales: {0}, during {1}", Sales[minMonth], Months[minMonth]);
            Console.WriteLine("The average monthly sales was: {0}", avg);
            return;
        }
    }
}
