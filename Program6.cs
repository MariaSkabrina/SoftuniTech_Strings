using System;
using System.Text;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            String number1 = Console.ReadLine();
            String number2 = Console.ReadLine();

            int numberMaxLength = Math.Max(number1.Length, number2.Length);

            number1 = number1.PadLeft(numberMaxLength, '0');
            number2 = number2.PadLeft(numberMaxLength, '0');
            StringBuilder result = new StringBuilder();
            int reminder = 0;
            for (int i = numberMaxLength - 1; i >= 0; i--)
            {
                int firstDigit = int.Parse(number1[i].ToString());
                int secondDigit = int.Parse(number2[i].ToString());
                int currentSum = firstDigit + secondDigit + reminder;
                reminder = 0;
                if (currentSum > 9)
                {
                    currentSum -= 10;
                    reminder++;
                }
                result.Append(currentSum);
            }
            result.Append(reminder);
            string output = result.ToString().TrimEnd('0');
            for (int i = output.Length - 1; i >=0; i--)
            {
                Console.Write(output[i]);
            }
            
            
            }
        }
    }

