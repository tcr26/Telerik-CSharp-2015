using System;

namespace _13.Binary_to_Decimal_Number
{
    class BinarytoDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter the binary number:");
            string input = Console.ReadLine();
            int power = 1;
            long result = 0;


            for (int i = input.Length - 1; i >= 0; i -= 1)
            {
                int number = input[i] - 48;
                result += number * power;
                power *= 2;
            }
            Console.WriteLine(result);
            Main();
        }
    }
}
