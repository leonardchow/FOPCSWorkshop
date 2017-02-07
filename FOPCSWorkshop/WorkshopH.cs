using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorkshop
{
    class WorkshopH
    {
        static void Main()
        {
            do
            {
                question4();
            } while (true);

            return;
        }

        static void question4()
        {
            string s = "This is the sentence that will be replaced.";
            string input = "", output = "";
            char[] chars = new char[3];

            Console.WriteLine("Substitute char example");
            Console.WriteLine(s);

            Console.Write("Please enter 2 characters with a space: ");
            input = Console.ReadLine();

            chars = input.ToCharArray();

            output = Substitute(s, chars[0], chars[2]);

            Console.WriteLine("{0}, {1}", chars[0], chars[2]);
            Console.WriteLine(output);
            Console.WriteLine();

            return;
        }

        static string Substitute(string s, char c1, char c2)
        {
            char[] sc = s.ToCharArray();

            for (int i = 0; i < s.Length; i++) // Iterate through string s
            {

                if (sc[i] == c1)
                {
                    sc[i] = c2;
                }
            }

            return new string(sc);
        }

        static void question3()
        {
            string input = "";
            int number = 0;
            string hexResult = "EMPTY";
            Console.WriteLine("Hexadecimal conversion");
            Console.WriteLine("Hex chart:");
            for (int i = 1; i <= 100; i++)
            {
                string hex = i.ToString("X");
                Console.Write("{0}:{1}\t", i, hex);
            }
            Console.WriteLine();

            while (number >= 0)
            {
                Console.Write("Please input an integer: ");
                input = Console.ReadLine();
                int.TryParse(input, out number);

                hexResult = toHex(number);
                Console.WriteLine(hexResult);
                Console.WriteLine();
            }
            Console.WriteLine("Exiting...");
        }

        static string toHex(int number)
        {
            string hexOnes = "";
            int hexTens = 0;
            
            if (number >= 16)
            {
                hexTens = number / 16;
                number -= hexTens * 16;
            }

            if (number <= 9)
            {
                hexOnes = number.ToString();
            } else
            {
                number -= 10;
                char ones = (char)('A' + number);
                hexOnes = ones.ToString();
            }

            if (hexTens > 0)
            {
                return hexTens + hexOnes;
            } else
            {
                return hexOnes;
            }
        }
        
        static void question2()
        {
            string input;
            string s1 = "The bras basah complex";

            Console.WriteLine("FindWord Example");
            Console.WriteLine(s1);
            Console.Write("Please enter a word: ");
            input = Console.ReadLine();

            Console.WriteLine(FindWord(s1, input));
            Console.WriteLine();

            return;
        }

        static int FindWord(string s1, string s2)
        {
            //int result = -1;

            if (s2.Length > s1.Length || s1.Length == 0 || s2.Length == 0) return -1; // no string or s2 longer
            if (s1.Length == s2.Length) // Strings are same length
            {
                if (string.Compare(s1, s2, true) == 0) return 0; // Strings are the same
                else return -1; // Strings are not the same
            }

            char firstChar = char.ToLower(s2[0]);

            for (int i = 0; i < s1.Length; i++) // Iterate through s1
            {
                if (char.ToLower(s1[i]) == firstChar) // Check every s1 character to see if it matches s2[0]
                {
                    if (s2.Length == 1) // If it is only a single letter
                    {
                        return i; // Return s1's index
                    }
                    for (int j = 1; j < s2.Length; j++) // Start at [1] because first char has matched already
                    {
                        if (i + j < s1.Length && char.ToLower(s2[j]) != char.ToLower(s1[i + j])) // If in range && not matching
                        {
                            break; // Exit j loop if any part of s2 does not match. So that you can try again!
                        }
                        if (j == s2.Length - 1) // If you have reached the end of s2, it is a match
                        {
                            return i;
                        }
                    }
                }
            }

            return -1;
        }

        static void question1()
        {
            string input;
            string s1 = "The bras basah complex";

            Console.WriteLine("InString Example");
            Console.WriteLine(s1);
            Console.Write("Please enter a string: ");
            input = Console.ReadLine();

            Console.WriteLine(InString(s1, input) ? "Inside" : "NOT INSIDE");
            Console.WriteLine();

            return;
        }
        
        static bool InString(string s1, string s2)
        {
            if (s2.Length > s1.Length || s1.Length == 0 || s2.Length == 0) return false; // no string or s2 longer
            if (s1.Length == s2.Length) // Strings are same length
            {
                if (string.Compare(s1, s2, true) == 0) return true; // Strings are the same
                else return false; // Strings are not the same
            }

            char firstChar = char.ToLower(s2[0]);

            for (int i = 0; i < s1.Length; i++) // Iterate through s1
            {
                if (char.ToLower(s1[i]) == firstChar) // Check every s1 character to see if it matches s2[0]
                {
                    if (s2.Length == 1) // If it is only a single letter
                    {
                        return true;
                    }
                    for (int j = 1; j < s2.Length; j++) // Start at [1] because first char has matched already
                    {
                        if (i+j < s1.Length && char.ToLower(s2[j]) != char.ToLower(s1[i+j])) // If in range && not matching
                        {
                            break; // Exit j loop if any part of s2 does not match. So that you can try again!
                        }
                        if (j == s2.Length - 1) // If you have reached the end of s2, it is a match
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
