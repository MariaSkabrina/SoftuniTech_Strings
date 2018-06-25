using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {

            String text = Console.ReadLine();
            String key = Console.ReadLine();

            while (true)
            {
                int firstIndex = text.IndexOf(key);
                int lastIndex = text.LastIndexOf(key);
                if (firstIndex == -1 || firstIndex == lastIndex || key == "")
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                text = text.Remove(lastIndex, key.Length);
                text = text.Remove(firstIndex, key.Length);

                key = key.Remove(key.Length / 2, 1);

                Console.WriteLine("Shaked it.");
            }
            for (int i = 0; i < text.Length; i ++)
            {
                Console.Write(text[i]);
            }
        }

    }
}