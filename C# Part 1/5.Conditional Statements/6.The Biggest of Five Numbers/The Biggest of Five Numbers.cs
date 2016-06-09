using System;

namespace _6.The_Biggest_of_Five_Numbers
{
    class TheBiggestofFiveNumbers
    {
        static void Main()
        {
            double min = Int32.MinValue;
            for (double i = 0; i < 5; i += 1)
            {
                double numbers = double.Parse(Console.ReadLine());
                min = Math.Max(min, numbers);
            }
            Console.WriteLine(min);
            Main();
        }
    }
}
