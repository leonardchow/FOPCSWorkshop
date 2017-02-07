using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorkshop
{
    class WorkshopG
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                question4();
                keepRunning = false;
            }
        }

        static void question4WithLists()
        {
            List<string> Names = new List<string>(new string[] { "John", "Venkat", "Mary", "Victor", "Betty" });
            List<int> Marks = new List<int>(new int[] { 63, 29, 75, 82, 55 });

            var namesAndMarks = Names.Zip(Marks, (n, m) => new { Name = n, Mark = m });

            foreach (var item in namesAndMarks)
            {
                Console.WriteLine("{0}\t{1}", item.Name, item.Mark);
            }
            Console.WriteLine();

            namesAndMarks = namesAndMarks.OrderByDescending(x => x.Mark).ToList();

            Console.WriteLine("Report 2: Ordered by Marks ");
            foreach (var item in namesAndMarks)
            {
                Console.WriteLine("{0}\t{1}", item.Name, item.Mark);
            }
            Console.WriteLine();

            namesAndMarks = namesAndMarks.OrderBy(x => x.Name).ToList();

            Console.WriteLine("Report 2: Ordered by Names ");
            foreach (var item in namesAndMarks)
            {
                Console.WriteLine("{0}\t{1}", item.Name, item.Mark);
            }
            Console.WriteLine();

            return;
        }

        static void question4()
        {
            // Examples of strings and arrays
            Console.WriteLine("Examples involving String and Arrays: ");
            int SIZE = 5;
            int[] Marks = new int[5] { 63, 29, 75, 82, 55 };
            string[] Names = new string[5] { "John", "Venkat","Mary","Victor","Betty"};
            int[] MarksOrig = new int[5];
            string[] NamesOrig = new string[5];
            Marks.CopyTo(MarksOrig, 0);
            Names.CopyTo(NamesOrig, 0);
            int[] MarksSort = new int[5] { 0, 1, 2, 3, 4 };
            int[] NamesSort = new int[5] { 0, 1, 2, 3, 4 };

            // Sort Marks array
            int swap = 0;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = i+1; j < SIZE; j++)
                {
                    if (Marks[i] <= Marks[j])
                    {
                        swap = Marks[i];
                        Marks[i] = Marks[j];
                        Marks[j] = swap;

                        swap = MarksSort[i];
                        MarksSort[i] = MarksSort[j];
                        MarksSort[j] = swap;
                    }
                }
            }

            // Sort Names array
            // Negative String.Compare() means strA is preceeds strB
            string nameSwap = "";
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = i + 1; j < SIZE; j++)
                {
                    if (string.Compare(Names[i], Names[j], true) > 0)
                        // If Str.Cmp is > 0, strA follows strB
                    {
                        nameSwap = Names[i];
                        Names[i] = Names[j];
                        Names[j] = nameSwap;

                        swap = NamesSort[i];
                        NamesSort[i] = NamesSort[j];
                        NamesSort[j] = swap;
                    }
                }
            }

            Console.WriteLine("Report 1 (Sorted by Marks)");
            Console.WriteLine("Name\t\tMark");

            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(" {0}", NamesOrig[MarksSort[i]]);
                Console.Write("\t\t");
                Console.Write(" {0}", MarksOrig[MarksSort[i]]);
                Console.Write("\n");
            }
            Console.WriteLine();

            Console.WriteLine("Report 2 (Sorted by Names)");
            Console.WriteLine("Name\t\tMark");

            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(" {0}", NamesOrig[NamesSort[i]]);
                Console.Write("\t\t");
                Console.Write(" {0}", MarksOrig[NamesSort[i]]);
                Console.Write("\n");
            }

            return;
        }

        static void question3()
        {
            string input;
            Console.Write("(Change case) Please enter a line: ");
            input = Console.ReadLine();

            for (int i=0; i < input.Length; i++)
            {
                if (i == 0 && char.IsLetter(input[0])) // Change first letter to upper case
                {
                    input = q3CharToUpper(input, i);
                }

                if (input[i] == ' ' && (i + 1 < input.Length) && char.IsLetter(input[i + 1]))
                    //      ^                   ^                           ^
                    //      If there is a       And the next char is        And it is
                    //      space               not out of range            a letter       
                {
                    input = q3CharToUpper(input, i+1);
                }
            }

            Console.WriteLine(input);

            return;
        }

        static string q3CharToUpper (string input, int pos)
        {
            StringBuilder sb = new StringBuilder(input);
            sb[pos] = char.ToUpper(input[pos]);

            return sb.ToString();
        }

        static void question2()
        {
            string input, original;
            bool isPalindrome = true;
            Console.Write("(Palindrome) Please enter a line: ");
            input = Console.ReadLine();
            original = input;

            // Sanitise string
            for (int j = 0; j < input.Length; j++)
            {
                if ( !(char.IsLetter(input[j])) )
                {
                    //Console.WriteLine(input[j]);
                    input = input.Remove(j, 1);
                    j--;
                }
            }

            for (int i = 0; i < input.Length/2; i++)
            {
                char checkFirst = char.ToLower(input[i]);
                char checkSecond = char.ToLower(input[input.Length - i - 1]);
                if (checkFirst != checkSecond)
                {
                    isPalindrome = false;
                    break;
                }
                //Console.WriteLine(input[i]);
            }

            Console.WriteLine("{0} is{1}a palindrome.", original, (isPalindrome ? " " : " not "));

            return;
        }

        static void question1()
        {
            string input;
            int cA = 0, cE = 0, cI = 0, cO = 0, cU = 0;
            int cTotal;
            //Console.WriteLine('a' - 'A');

            Console.Write("Please enter a line: ");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A' || input[i] == 'a')
                {
                    cA++;
                } else if (input[i] == 'E' || input[i] == 'e')
                {
                    cE++;
                } else if (input[i] == 'I' || input[i] == 'i')
                {
                    cI++;
                } else if (input[i] == 'O' || input[i] == 'o')
                {
                    cO++;
                } else if (input[i] == 'U' || input[i] == 'u')
                {
                    cU++;
                }
            }

            cTotal = cA + cE + cI + cO + cU;

            Console.WriteLine("Total vowels: {0}\nA: {1}\nE: {2}\nI: {3}\nO: {4}\nU: {5}", cTotal, cA, cE, cI, cO, cU);

            return;
        }
    }
}