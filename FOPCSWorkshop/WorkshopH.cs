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
                question3();
            } while (false);

            return;
        }

        static void question3()
        {
            Console.WriteLine("Hexadecimal conversion");
            Console.WriteLine("Hex chart:");
            for (int i = 1; i <= 100; i++)
            {
                string hex = i.ToString("X");
                Console.Write("{0}\t", hex);
            }
            Console.WriteLine();
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
