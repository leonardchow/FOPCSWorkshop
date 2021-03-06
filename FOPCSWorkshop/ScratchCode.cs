﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FOP
{
    class ScratchCode
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 1, 1 };
            a[2] = 10;
            Console.WriteLine(a[2]);
        }

        static void ListThings()
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
    }
}