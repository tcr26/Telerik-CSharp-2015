using System;

namespace _6.Four_Digit_Number
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter an number:");
            string number = Console.ReadLine();
            short numberCheck = short.Parse(number);
            int sum = 0;
            int number1 = (int)char.GetNumericValue(number[0]);
            int number2 = (int)char.GetNumericValue(number[1]);
            int number3 = (int)char.GetNumericValue(number[2]);
            int number4 = (int)char.GetNumericValue(number[3]);

            if (number.Length > 4)
            {
                Console.WriteLine("Enter a four digit number:");
                return;

            }
            else if (number1 == 0)
            {
                Console.WriteLine("Enter a digit without leading 0");
                return;
            }

            for (int i = 0; i < number.Length; i++)
            {
                sum += (int)char.GetNumericValue(number[i]);
            }

            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", number4, number3, number2, number1);
            Console.WriteLine("{0}{1}{2}{3}", number4, number1, number2, number3);
            Console.WriteLine("{0}{1}{2}{3}", number4, number1, number2, number3);
            Console.WriteLine("{0}{1}{2}{3}", number1, number3, number2, number4);
        }
    }
}
