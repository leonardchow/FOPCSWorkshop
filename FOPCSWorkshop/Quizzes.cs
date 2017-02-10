using System;

namespace FOPCSWorkshop
{
    class Quizzes
    {
        public static void Main(string[] args)
        {
            while (true) {
                QuizDay6();
            }

            return;
        }

        static int[] minIncomeArray = new int[] { 20000, 30000, 40000, 80000, 120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[] { 0.02, 0.035, 0.07, 0.115, 0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[] { 0, 200, 550, 3350, 7950, 13950, 20750, 42350 };

        public static void QuizDay6()
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        static int AskForIncome()
        {
            bool inputWasOK = false;
            int annualIncome = 0;

            do
            {
                string input = "";
                Console.Write("Please enter your annual taxable income: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out annualIncome))
                {
                    inputWasOK = true;
                } else
                {
                    Console.WriteLine("That was not a recognised taxable income. Please try again.\n");
                }
            } while (!inputWasOK);
            
            return annualIncome;
        }

        static int GetTaxBracket(int annualIncome)
        {
            int minIncomeArrayIndex = -1;
            for (int i = minIncomeArray.Length - 1; i >= 0; i--)
            {
                if (minIncomeArray[i] < annualIncome)
                {
                    minIncomeArrayIndex = i;
                    break;
                }
            }
            return minIncomeArrayIndex;
        }

        static double CalculateIncomeTax(int annualIncome, int taxBracketIndex)
        {
            double taxPayable = 0.0;
            if (taxBracketIndex == -1)
            {
                return taxPayable;
            }
            int minIncome = minIncomeArray[taxBracketIndex];
            double taxRate = taxRateArray[taxBracketIndex];
            int basePayableAmount = basePayableAmountArray[taxBracketIndex];

            taxPayable = (annualIncome - minIncome) * taxRate + basePayableAmount;
            return taxPayable;
        }

        static void PrintResult(int annualIncome, double taxPayable)
        {
            Console.WriteLine("For taxable annual income of {0:c}, the tax payable amount is {1:c}\n", annualIncome, taxPayable);
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
