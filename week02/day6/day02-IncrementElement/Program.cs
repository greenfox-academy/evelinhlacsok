﻿using System;
using System.Collections.Generic;

namespace day02_IncrementElement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element

            int[] t = {1, 2, 3, 4, 5};
            t[2]++;
            Console.WriteLine(t[2]);
        }
    }
}