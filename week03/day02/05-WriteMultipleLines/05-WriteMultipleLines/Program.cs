﻿using System;
using System.IO;

namespace WriteMultipleLines
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			// Create a function that takes 3 parameters: a path, a word and a number,
			// than it should write to a file.
			// The path parameter should be a string, that describes the location of the file.
			// The word parameter should be a string, that will be written to the file as lines
			// The number paramter should describe how many lines the file should have.
			// So if the word is "apple" and the number is 5, than it should write 5 lines
			// to the file and each line should be "apple"
			// The function should not raise any error if it could not write the file.

            string path = @"./lorem-ipsum.txt";
            string word = "succulents";
            int number = 8;
            MultipleLines(path, word, number);
           // Console.ReadLine();

		}
        private static void MultipleLines (string path, string word, int number)
        {
            try
            {
				using (StreamWriter writer = new StreamWriter(path))
				{
					for (int i = 0; i < number; i++)
					{
						writer.WriteLine(word);
					}
				}
            }

            catch (Exception)
            {
                Console.WriteLine("Unable to write file");
            }
        }
    }
}
