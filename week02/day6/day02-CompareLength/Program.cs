﻿using System;
using System.Collections.Generic;

namespace day02_CompareLength
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`

            int[] p1 = {1, 2, 3};
            int[] p2 = {4, 5};

            if (p1.Length < p2.Length)
            {
                Console.WriteLine("p2 has more elements than p1");
            }
            else
            {
                Console.WriteLine("p1 has more elements than p2");
            }

        }
    }
}