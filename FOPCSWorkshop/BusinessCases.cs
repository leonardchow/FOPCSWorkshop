using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorkshop
{
    class BusinessCases
    {

        public static void Main(string[] args)
        {
            bool keepRunning;
            do
            {
                keepRunning = BusCase3();

            } while (keepRunning);

            return;
        }

        public static bool BusCase3()
        {
            string input = "";
            Console.WriteLine("Welcome to Dafesty Encryption Prg 3000!");
            Console.WriteLine("Please enter a string to encrypt: (quit to exit)");

            input = Console.ReadLine();

            if (input == "quit") return false;

            Console.WriteLine(Encrypt(input));
            Console.WriteLine();

            return true;
        }

        public static string Encrypt(string s)
        {
            Console.WriteLine("Encrypting...");
            if (!isAlphaNum(s))
            {
                return s + " is not a valid alphanumeric string.\n";
            }
            Console.WriteLine(s);
            char[] s1 = s.ToCharArray();

            // First transform
            for (int i = 0; i < s.Length; i++)
            {
                if (s1[i] == 'z') s1[i] = 'a';
                else if (s1[i] == 'Z') s1[i] = 'A';
                else if (s1[i] == '9') s1[i] = '0';
                else
                {
                    s1[i]++;
                }
                Console.Write(s1[i]);
            }
            Console.WriteLine();

            // Second transform
            char swap = ' ';
            for (int j = 0; j < s.Length / 2; j++)
            {
                swap = s1[j];
                s1[j] = s1[s.Length - 1 - j];
                s1[s.Length - 1 - j] = swap;
            }

            string s2 = new string(s1);

            Console.WriteLine("Done.");
            Console.WriteLine();

            return s2;
        }

        public static bool isAlphaNum(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if ( ! char.IsLetterOrDigit(s[i]) )
                {
                    return false;
                }
            }
            return true;
        }

        public static void BusCase2()
        {
            // Old code: 18 52
            // New code:    52 0 839
            string[] sArr = new string[]
            {
                "Hougang avenue 5 block 320 Singapore 2022   ",
                "Bukit Batok AVE 3 BLK 121 Singapore 4442  ",
                "bLK 123H Jalan Membina singapore 1212"
            };
            string input = "";
            int choice = 0;

            Console.WriteLine("================================================================");
            Console.WriteLine("Welcome to the Dafesty Data Migration Prg 1000 for Postal Codes!");
            Console.WriteLine();
            Console.WriteLine("ADDRESSES IN MEMORY:");
            
            for (int i = 0; i < sArr.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, sArr[i]);
            }

            Console.WriteLine();
            Console.Write("Please select an address to parse: ");

            input = Console.ReadLine();
            if (!(int.TryParse(input, out choice)))
            {
                Console.WriteLine("\nNO CHOICE MADE!\n");
                return;
            }

            choice -= 1; // Convert to zero-based scale

            if (choice > sArr.Length - 1 || choice < 0)
            {
                Console.WriteLine("\nINVALID CHOICE MADE!\n");
                return;
            }

            Console.WriteLine("New Code: {0}", postalCodeRefactor(sArr[choice]));
            Console.WriteLine();
        }

        public static string postalCodeRefactor(string s)
        {
            string newPostalCode = "";
            string s0 = s.ToLower(); // Make it all lowercase so it is easier to compare

            string sgStr = "singapore";
            int sgIndex = WorkshopH.FindWord(s0, sgStr);

            if (sgIndex >= 0) // Found the word singapore
            {
                string postcode4d = s0.Substring(sgIndex + sgStr.Length); // Get substring after "singapore"
                postcode4d = postcode4d.Trim(); // Remove whitespace
                if (postcode4d.Length != 4) // See if we isolated the 4-digit postal code
                {
                    Console.WriteLine("Couldn't find 4-digit postal code"); // ERROR
                    return newPostalCode;
                }
                newPostalCode += postcode4d.Substring(2, 2); // Put the l2 last digits into the new postal code
            } else
            {
                Console.WriteLine("Couldn't find singapore"); // ERROR
                return newPostalCode;
            }

            string[] blkStr = new string[2] { "blk", "block" };
            int blkIndex = -1;
            string blkWord = "";

            for (int i = 0; i < blkStr.Length; i++)
            {
                int b = WorkshopH.FindWord(s0, blkStr[i]);
                if (b >= 0) // Found word in this iteration
                {
                    blkIndex = b;
                    blkWord = blkStr[i];
                    break;
                }
            }

            if (blkIndex >= 0) // Found the word blk or block
            {
                string blocknumber = s0.Substring(blkIndex + blkWord.Length, 5); // Includes whitespace and possible letter
                blocknumber = blocknumber.Trim();

                if (blocknumber.Length == 3) // There is NO character behind
                {
                    newPostalCode += "0" + blocknumber;
                } else if (blocknumber.Length == 4) // There is a character behind
                {
                    if (char.IsLetter(blocknumber[3])) // Checks if it is indeed a letter
                    {
                        int intBlkLetter = blocknumber[3] - 'a' + 1;
                        blocknumber = blocknumber.Substring(0, 3);
                        newPostalCode += intBlkLetter + blocknumber; // Found the whole thing. Will return below
                    } else
                    {
                        Console.WriteLine("Couldn't parse block number's letter"); // ERROR
                        return newPostalCode;
                    }
                } else
                {
                    Console.WriteLine("Couldn't parse block number");
                    return newPostalCode;
                }
            } else
            {
                Console.WriteLine("Couldn't find block");
                return newPostalCode;
            }
            Console.WriteLine();
            return newPostalCode;
        }

        public static void BusCase1ALT()
        {
            string input = "";
            string[] ones = new string[10] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] tens = new string[10] { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] teen = new string[10] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

            string sDollars = "";
            string sCents = "";
            int dollars = 0;
            int cents = 0;

            Console.WriteLine("Welcome to Dafesty Video Rental!");
            Console.Write("Please enter amount ($$$$.¢¢): ");
            input = Console.ReadLine();

            if (input.IndexOf('.') >= 0 &&
                int.TryParse(input.Split('.')[0], out dollars) &&
                int.TryParse(input.Split('.')[1], out cents) &&
                input.Split('.')[1].Length == 2)
            {
                // Code for cents
                if (cents > 0)
                {
                    sCents = "Cents ";
                    string sCentsTens = "";
                    string sCentsOnes = "";

                    int cTens = cents / 10;
                    int cOnes = cents % 10;

                    if (cTens > 0)
                    {
                        sCentsTens = tens[cTens] + " ";
                    }

                    if (cOnes > 0)
                    {
                        if (cTens == 1)
                        {
                            sCentsTens = teen[cOnes] + " ";
                        } else
                        {
                            sCentsOnes = ones[cOnes] + " ";
                        }
                    }

                    sCents = sCents + sCentsTens + sCentsOnes;

                    if (cents == 1) sCents = "Cent One ";
                }

                // Code for dollars
                if (dollars > 0)
                {
                    sDollars = "Dollars ";
                    string sDollarsThou = "";
                    string sDollarsHuns = "";
                    string sDollarsTens = "";
                    string sDollarsOnes = "";

                    int dThou = dollars / 1000;
                    int dHuns = dollars / 100 - dThou * 10;
                    int dTens = dollars / 10 - dHuns * 10 - dThou * 100;
                    int dOnes = dollars % 10;

                    // Generate text
                    if (dThou > 0)
                    {
                        sDollarsThou = ones[dThou] + " thousand ";
                    }
                    if (dHuns > 0)
                    {
                        sDollarsHuns = ones[dHuns] + " hundred ";
                    }
                    if (dTens > 0)
                    {
                        sDollarsTens = tens[dTens] + " ";
                    }
                    if (dOnes > 0)
                    {
                        if (dTens == 1)
                        {
                            sDollarsTens = teen[dOnes] + " ";
                        } else
                        {
                            sDollarsOnes = ones[dOnes] + " ";
                        }
                    }

                    // Combine them
                    if (dHuns > 0 && dOnes + dTens > 0)
                    {
                        sDollarsHuns += "and ";
                    }

                    sDollars = sDollars + sDollarsThou + sDollarsHuns + sDollarsTens + sDollarsOnes;

                    if (dollars == 1)
                    {
                        sDollars = "Dollar One ";
                    }

                    if (cents > 0)
                    {
                        sDollars = sDollars + "and ";
                    }
                }

            }
            else
            {
                Console.WriteLine("Input was wrong. Please try again.");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("{0}{1}only.", sDollars, sCents);
            Console.WriteLine();

            return;
        }

        public static void BusCase1()
        {
            string input = "";
            string[] ones = new string[10] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] tens = new string[10] { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] teen = new string[10] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

            string sDollars = "";
            string sCents = "";
            int dollars = 0;
            int cents = 0;

            Console.WriteLine("Welcome to Dafesty Video Rental!");
            Console.Write("Please enter amount ($$$$.¢¢): ");
            input = Console.ReadLine();

            if (input.IndexOf('.') >= 0 &&
                int.TryParse(input.Split('.')[0], out dollars) &&
                int.TryParse(input.Split('.')[1], out cents) &&
                input.Split('.')[1].Length == 2)
            {
                // Code for cents
                if (cents > 0)
                {
                    sCents = "Cents ";
                    if (cents < 10)
                    {
                        if (cents == 1) sCents = "Cent One";
                        else sCents = sCents + ones[cents];
                    } else if (cents < 20)
                    {
                        sCents = sCents + teen[cents - 10];
                    } else
                    {
                        int cTens = cents / 10;
                        int cOnes = cents % 10;
                        if (cOnes == 0)
                        {
                            sCents = sCents + tens[cTens];
                        }
                        else
                        {
                            sCents = sCents + tens[cTens] + " " + ones[cOnes];
                        }
                    }
                }

                // Code for dollars
                if (dollars > 0)
                {
                    sDollars = "Dollars ";
                    if (dollars < 10)
                    {
                        if (dollars == 1) sDollars = "Dollar One";
                        else sDollars = sDollars + ones[dollars];
                    }
                    else if (dollars < 100)
                    {
                        if (dollars < 20)
                        {
                            sDollars = sDollars + teen[dollars - 10];
                        }
                        else
                        {
                            int dTens = dollars / 10;
                            int dOnes = dollars % 10;
                            if (dOnes > 0)
                            {
                                sDollars = sDollars + tens[dTens] + " " + ones[dOnes];
                            }
                            else
                            {
                                sDollars = sDollars + tens[dTens];
                            }
                        }
                    } 
                    else if (dollars < 1000)
                    {
                        int dHuns = dollars / 100;
                        int dTens = dollars / 10 - dHuns * 10;
                        int dOnes = dollars % 10;

                        if (dOnes > 0)
                        {
                            if (dTens == 0)
                            {
                                sDollars = sDollars + ones[dHuns] + " hundred and " + ones[dOnes];
                            }
                            else if (dTens == 1) // in Teens
                            {
                                sDollars = sDollars + ones[dHuns] + " hundred and " + teen[dOnes];
                            }
                            else
                            {
                                sDollars = sDollars + ones[dHuns] + " hundred and " + tens[dTens] + " " + ones[dOnes];
                            }
                        }
                        else // dOnes == 0
                        {
                            if (dTens == 0) // : 100
                            {
                                sDollars = sDollars + ones[dHuns] + " hundred";
                            }
                            else // : 110
                            {
                                sDollars = sDollars + ones[dHuns] + " hundred and " + tens[dTens];
                            }
                        }
                    }
                    else if (dollars < 10000)
                    {
                        int dThou = dollars / 1000;
                        int dHuns = dollars / 100 - dThou * 10;
                        int dTens = dollars / 10 - dHuns * 10 - dThou * 100;
                        int dOnes = dollars % 10;

                        Console.WriteLine("{0} {1} {2} {3}", dThou, dHuns, dTens, dOnes);

                        if (dOnes > 0)
                        {
                            // sDollars = sDollars + ones[dThou] + " thousand and " + ones[dHuns] + " hundred and " + tens[dTens]
                            if (dTens == 0)
                            {
                                if (dHuns == 0) // : 1001
                                {
                                    sDollars = sDollars + ones[dThou] + " thousand and " + ones[dOnes];
                                } else // : 1101
                                {
                                    sDollars = sDollars + ones[dThou] + " thousand and " + ones[dHuns] + " hundred and " + ones[dOnes];
                                }
                            }
                            else if (dTens == 1)
                            {
                                if (dHuns == 0) // : 1015
                                {
                                    sDollars = sDollars + ones[dThou] + " thousand and " + teen[dOnes];
                                }
                                else // : 1115
                                {
                                    sDollars = sDollars + ones[dThou] + " thousand and " + ones[dHuns] + " hundred and " + teen[dOnes];
                                }
                            }
                            else // dTens >= 2
                            {
                                if (dHuns == 0) // : 1021
                                {
                                    sDollars = sDollars + ones[dThou] + " thousand and " + tens[dTens] + " " + ones[dOnes];
                                }
                                else // : 1121
                                {
                                    sDollars = sDollars + ones[dThou] + " thousand and " + ones[dHuns] + " hundred and " + tens[dTens] + " " + ones[dOnes];
                                }
                            }
                        }
                        else // dOnes == 0
                        {
                            if (dTens == 0) // : 1100
                            {
                                if (dHuns == 0) // 1000
                                {
                                    sDollars = sDollars + ones[dThou] + " thousand";
                                } else
                                {
                                    sDollars = sDollars + ones[dThou] + " thousand and " + ones[dHuns] + " hundred";
                                }
                            }
                            else // dTens > 0
                            {
                                if (dHuns == 0) // : 1010
                                {
                                    sDollars = sDollars + ones[dThou] + " thousand and " + tens[dTens];
                                }
                                else // : 1110
                                {
                                    sDollars = sDollars + ones[dThou] + " thousand and " + ones[dHuns] + " hundred and " + tens[dTens];
                                }
                            }
                        }
                    }

                    if (cents > 0)
                    {
                        sDollars = sDollars + " and ";
                    }
                }
                
            } else
            {
                Console.WriteLine("Input was wrong. Please try again.");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("{0}{1} only.", sDollars, sCents);
            Console.WriteLine();

            return;
        }
    }
}
