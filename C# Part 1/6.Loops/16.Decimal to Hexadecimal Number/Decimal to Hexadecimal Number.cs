using System;

namespace _17.Decimal_to_Hexadecimal_Number
{
    class DecimalToHexadecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter number:");
            long input = long.Parse(Console.ReadLine());
            string strNumber = "";
            int power = 1;
            long result = 0;

            if (input == 0)
            {
                strNumber = "0";
            }

            while (input > 0)
            {

                long remainder = input % 16;
                input /= 16;
                switch (remainder)
                {
                    case 10:
                        strNumber = "A" + strNumber;
                        break;
                    case 11:
                        strNumber = "B" + strNumber;
                        break;
                    case 12:
                        strNumber = "C" + strNumber;
                        break;
                    case 13:
                        strNumber = "D" + strNumber;
                        break;
                    case 14:
                        strNumber = "E" + strNumber;
                        break;
                    case 15:
                        strNumber = "F" + strNumber;
                        break;
                    default:
                        strNumber = remainder + strNumber;
                        break;
                }
            }
            Console.WriteLine(strNumber);
            Main();
        }
    }
}



//string hex = input.ToString("x");