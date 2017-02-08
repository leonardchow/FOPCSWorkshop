using System;

namespace FOPCSWorkshop
{
    class Quizzes
    {
        public static void Main(string[] args)
        {
            QuizDay4();

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
