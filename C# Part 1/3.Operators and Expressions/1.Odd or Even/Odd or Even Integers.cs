using System;

namespace _1.Odd_or_Even
{
    class OddorEvenIntegers
    {
        static void Main()
        {
            Console.Write("Enter an integer:");
            double number = double.Parse(Console.ReadLine());
            bool check = true;

            if (number == 0)
            {
                check = false;
            }
            if (number % 2 == 0)
            {
                Console.WriteLine(check);
            }
            else
            {
                check = false;
                Console.WriteLine(check);
            }
            Main();
        }
    }
}
