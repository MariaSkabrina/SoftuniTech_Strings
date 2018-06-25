using System;
using System.Text;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            String number1 = Console.ReadLine();
            String number2 = Console.ReadLine();
            int multiplier = int.Parse(number2);
            if (multiplier == 0)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }
            StringBuilder result = new StringBuilder();
            int reminder = 0;
            int currentSum = 0;

            for (int i = number1.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(number1[i].ToString());
                currentSum = digit * multiplier + reminder;
                result.Append(currentSum % 10);

                reminder = currentSum / 10;
               
            }
            result.Append(reminder);

            string output = result.ToString().TrimEnd('0');

            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }

        }
    }
}
