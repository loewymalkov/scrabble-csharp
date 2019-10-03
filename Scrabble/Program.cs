using System;
using System.Collections.Generic;
using Scrabble;

namespace Scrabble
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a word:");
            string input = Console.ReadLine();
            Console.WriteLine("the score for " + input + " is " + Calculations.StringToCharArray(input.ToUpper()));
        }
    }
}