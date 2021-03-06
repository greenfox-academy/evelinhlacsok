﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Lists02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> {"Eve", "Ashley", "Bözsi", "Kat", "Jane"};
            var boys = new List<string> {"Joe", "Fred", "Béla", "Todd", "Neef", "Jeff"};
            var order = new List<string>();

            for (int i = 0; i < boys.Count; i++)
            {
                if (girls.Count > i)
                {
                    order.Add(girls[i]);
                }
          
                order.Add(boys[i]);
            }
            foreach (var correctorder in order)
            {
                Console.Write(correctorder + ", ");
            }

            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...
            
           
           // Console.WriteLine(order);
        }
    }
}