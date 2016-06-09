using System;

namespace _15.Hexadecimal_to_Decimal_Number
{
    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter number:");
            string input = Console.ReadLine();
            long power = 1;
            long result = 0;

            for (int i = input.Length - 1; i >= 0; i -= 1)
            {
                int number;

                switch (input[i])
                {
                    case 'A':
                        number = 10;
                        break;
                    case 'B':
                        number = 11;
                        break;
                    case 'C':
                        number = 12;
                        break;
                    case 'D':
                        number = 13;
                        break;
                    case 'E':
                        number = 14;
                        break;
                    case 'F':
                        number = 15;
                        break;
                    default:
                        number = (int)input[i] - 48;
                        break;
                }
                result += number * power;
                power *= 16;
            }

            Console.WriteLine(result);
            Main();
        }
    }
}


//int output1 = int.Parse(input, System.Globalization.NumberStyles.HexNumber);
//int output2 = Convert.ToInt32(input, 16);
