using System;

namespace _7.Sum_of_5_Numbers
{
    class Sumof5Numbers
    {
        static void Main()
        {
            Console.Write("Enter 5 numbers separate by spaces: ");
            string[] input = Console.ReadLine().Split();
            double result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                result += double.Parse(input[i]);
            }
            Console.WriteLine(result);
            Main();
        }
    }
}
