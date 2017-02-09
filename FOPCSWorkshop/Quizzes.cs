using System;

namespace FOPCSWorkshop
{
    class Quizzes
    {
        public static void Main(string[] args)
        {
            QuizDay5();

            return;
        }

        public static void QuizDay5()
        {
            string input = "";
            int[] array = new int[5];
            Console.Write("Please enter matriculation number: ");
            input = Console.ReadLine();

            if (input.Length != 7)
            {
                Console.WriteLine("Invalid");
                return;
            }

            input = input.ToUpper();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = input[i + 1] - '0';
            }

            int sum = array[0] * 6 + array[1] * 5 + array[2] * 4 + array[3] * 3 + array[4] * 2;
            Console.WriteLine(sum);
            int rem = sum % 5;

            if ((input[6] - 'O') == rem)
            {
                Console.WriteLine("Valid");
            } else
            {
                Console.WriteLine("Invalid");
            }

            return;
        }

        public static void QuizDay4()
        {
            string PIN = ("123456");
            Console.WriteLine("Welcome to the Bank of ISS");
            int tries = 0;
            while (tries < 3)
            {
                Console.Write("Enter your PIN: ");
                string input = Console.ReadLine();

                Console.WriteLine();

                if (input == PIN)
                {
                    Console.WriteLine("PIN accepted. You can access your account now.");
                    break;
                }
                if (tries < 2)
                {
                    Console.WriteLine("Incorrect PIN. Please try again.");
                    tries++;
                }
                else
                {
                    Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
                    break;
                }
            }

            return;
        }
    }
}
