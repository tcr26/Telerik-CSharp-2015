using System;

namespace _5.Third_Digit_is_7
{
    class ThirdDigitis7
    {
        static void Main()
        {
            Console.Write("Enter a digit: ");
            uint number = uint.Parse(Console.ReadLine());
            bool check = false;

            if ((number / 100) % 10 != 7)
            {
                Console.WriteLine(check);
            }
            else
            {
                check = true;
                Console.WriteLine(check);
            }
            Main();
        }
    }
}
