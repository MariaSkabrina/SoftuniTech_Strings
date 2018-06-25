using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split();
            String input1 = input[0];
            String input2 = input[1];
            int inputLength1 = input[0].Length;
            int inputLength2 = input[1].Length;

            int sum = 0;
            int a = 0;
            int b = 0;
            if (inputLength1 >= inputLength2)
            {
                
                for (int i = 0; i < inputLength2; i ++)
                {
                    a = input1[i];
                    b = input2[i];
                    sum = sum + a * b;
                }
                for (int i = inputLength2; i < inputLength1; i++)
                {

                    sum = sum + input1[i];
                }
                
            }
            else
            {
                
                for (int i = 0; i < inputLength1; i++)
                {
                    a = input1[i];
                    b = input2[i];
                    sum = sum + a * b;
                }
                for (int i = inputLength1; i < inputLength2; i++)
                {

                    sum = sum + input2[i];
                }
                
            }

            Console.WriteLine(sum);


        }
    }
}
