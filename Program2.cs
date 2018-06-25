using System;
using System.Numerics;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int @base = int.Parse(tokens[0]);
            string number = tokens[1];

            BigInteger sum = 0;
            int pow = 0;
            for (int i = number.Length - 1; i >= 0; i --)
            {
                char currentChar = number[i];
                int currentNumber = int.Parse(currentChar.ToString());

                BigInteger currentSum = currentNumber * BigInteger.Pow(@base, pow);
                sum = sum + currentSum;
                pow++;

            }

            Console.WriteLine(sum);
        }
    }
}
