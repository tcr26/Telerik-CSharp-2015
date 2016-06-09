using System;

namespace _3.Divide_by_7_and_5
{
    class Divideby7and5
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            bool check = false;

            if ((number % 5 == 0) && (number % 7 == 0))
            {
                check = true;
                Console.WriteLine(check);
            }
            else
            {
                Console.WriteLine(check);
            }
            Main();
        }
    }
}
