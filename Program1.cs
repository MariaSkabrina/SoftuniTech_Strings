using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] inputTokens = Console.ReadLine().Split();
            int @base = int.Parse(inputTokens[0]);
            BigInteger number = BigInteger.Parse(inputTokens[1]);
            StringBuilder converted = new StringBuilder();
            while (number>0)
            {
                BigInteger  remainder = number % @base;
                converted.Append(remainder);
                number /= @base;
            }

            for (int i = converted.Length - 1; i >=0; i--)

            {

                Console.Write(converted[i]);
            }

           // string reversedConvert = string.Join("", converted.ToString().Reverse());
         //   Console.WriteLine(reversedConvert);
        }
    }
}
