﻿using System;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] words = Console.ReadLine().Split(new char [] { ' ','\t'}, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;
            foreach (string word in words)
            {
                char first = word[0];
                char last = word[word.Length - 1];
                string numberAsString = word.Substring(1, word.Length - 2);
                int number = int.Parse(numberAsString);
                double sum = 0;
                if (char.IsUpper(first))
                {
                    sum += number / (first - 64.0);
                }
                else
                {
                    sum += number * (first - 96.0);

                }
                if (char.IsUpper(last))
                    sum -= last - 64.0;
                else
                    sum += last - 96.0;

                totalSum += sum;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
