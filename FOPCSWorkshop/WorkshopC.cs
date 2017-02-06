using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorkshop
{
    class WorkshopC
    {
        static void Main(string[] args)
        {
            while (true)
            {
                question6();
            }
        }

        static void question6()
        {
            int TV_COST = 900;
            int DVD_COST = 500;
            int MP3_COST = 700;
            string inputName;
            int inputCount=0, tvCount=0, dvdCount=0, mp3Count=0;
            double total;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter a product code (TV/DVD/MP3): ");
                inputName = Console.ReadLine();
                Console.Write("Please enter quantity: ");
                inputCount = Convert.ToInt32(Console.ReadLine());

                if (inputName == "TV" || inputName == "tv")
                {
                    tvCount = inputCount;
                } else if (inputName == "DVD" || inputName == "dvd")
                {
                    dvdCount = inputCount;
                } else
                {
                    mp3Count = inputCount;
                }
            }

            total = (tvCount * TV_COST) + (dvdCount * DVD_COST);
            if (total > 10000)
            {
                total *= 0.85;
            } else if (total > 5000)
            {
                total *= 0.9;
            }

            total += mp3Count * MP3_COST;

            Console.WriteLine("The discounted price is {0:c0}\n", total);

        }

        static void question5()
        {
            int input, first, second, third, check;
            bool armstrong = false;

            Console.Write("Please enter a 3 digit integer: ");
            input = Convert.ToInt32(Console.ReadLine());

            first = input / 100;
            second = (input / 10) - (first * 10);
            third = input - (first * 100 + second * 10);

            // Check Armstrong
            check = Convert.ToInt32(Math.Pow(first, 3) + Math.Pow(second, 3) + Math.Pow(third, 3));
            if (check == input)
            {
                armstrong = true;
            }

            Console.WriteLine(armstrong);
            return;
        }

        static void question4()
        {
            double MIN_CHARGE = 2.4;
            double RATE1 = 0.04;
            double RATE2 = 0.05;

            double input, fare;
            double minDist = 0.5, firstDist = 8.5;

            Console.Write("Please enter a distance in km: ");
            input = Convert.ToDouble(Console.ReadLine());

            // Round input to every 0.1 km
            input *= 10;
            input = Math.Ceiling(input);
            input /= 10;

            if (input <= minDist)
            {
                fare = MIN_CHARGE;
            } else if (input <= (minDist + firstDist))
            {
                input -= minDist;
                // multiply by 10 to convert to 100m
                fare = MIN_CHARGE + (input * 10) * RATE1;
            } else
            {
                input -= (minDist + firstDist);
                // multiply by 10 to convert to 100m
                fare = MIN_CHARGE + (firstDist * 10) * RATE1 + (input * 10) * RATE2;
            }

            Console.WriteLine("The fare is {0:c}\n", fare);
        }

        static void question3()
        {
            int score;
            string grade;
            Console.Write("Please enter a score from 0 to 100: ");
            score = Convert.ToInt32(Console.ReadLine());
            
            if (score < 0 || score > 100)
            {
                Console.WriteLine("**Error**");
                return;
            }

            if (score >= 80)
            {
                grade = "A";
            } else if (score >= 60)
            {
                grade = "B";
            } else if (score >= 40)
            {
                grade = "C";
            } else
            {
                grade = "F";
            }

            Console.WriteLine("You scored {0} marks which is {1} grade\n", score, grade);

            return;
        }

        static void question2()
        {
            string input, name, salut;
            int age;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.Write("Please enter your gender M/F: ");
            input = Console.ReadLine();
            salut = (input == "F") ? "Ms." : "Mr.";

            Console.Write("Please enter your age: ");
            input = Console.ReadLine();
            age = Convert.ToInt32(input);
            if (age >= 40)
            {
                if (salut == "Ms.")
                {
                    salut = "Aunty";
                } else
                {
                    salut = "Uncle";
                }
            }

            Console.WriteLine("Good Morning {0} {1}\n", salut, name);
        }

        static void question1()
        {
            string name, gender, salut;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your gender M/F: ");
            gender = Console.ReadLine();

            salut = (gender == "F") ? "Ms." : "Mr.";

            Console.WriteLine("Good Morning " + salut + " " + name + "\n");
        }
    }
}
