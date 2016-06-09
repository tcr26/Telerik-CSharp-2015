using System;

namespace _11.Number_as_Words
{
    class NumberAsWords
    {
        static void Main()
        {

            string hundred = " hundred";
            string[] numberEty = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] numberTeens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] zeroNineNumbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string and = " and ";

            Console.WriteLine();
            Console.Write("Enter a number in range [0-999]:");
            short numberInput = short.Parse(Console.ReadLine());
            byte hundredFormula = (byte)((numberInput / 100));
            byte numberEtyFormula = (byte)((numberInput / 10) % 10);
            byte numbersToNineFormula = (byte)(numberInput % 10);

            if (numberInput >= 0 && numberInput < 1000)
            {

                switch (hundredFormula)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write(zeroNineNumbers[1] + hundred);
                        break;
                    case 2:
                        Console.Write(zeroNineNumbers[2] + hundred);
                        break;
                    case 3:
                        Console.Write(zeroNineNumbers[3] + hundred);
                        break;
                    case 4:
                        Console.Write(zeroNineNumbers[4] + hundred);
                        break;
                    case 5:
                        Console.Write(zeroNineNumbers[5] + hundred);
                        break;
                    case 6:
                        Console.Write(zeroNineNumbers[6] + hundred);
                        break;
                    case 7:
                        Console.Write(zeroNineNumbers[7] + hundred);
                        break;
                    case 8:
                        Console.Write(zeroNineNumbers[8] + hundred);
                        break;
                    case 9:
                        Console.Write(zeroNineNumbers[9] + hundred);
                        break;
                    default:
                        break;
                }

                if (numberInput % 100 != 0 && numberInput / 100 != 0)
                {
                    Console.Write(and);
                }

                switch (numberEtyFormula)
                {
                    case 0:
                        break;
                    case 1:

                        switch (numbersToNineFormula)
                        {
                            case 0:
                                Console.Write(numberTeens[0]);
                                break;
                            case 1:
                                Console.Write(numberTeens[1]);
                                break;
                            case 2:
                                Console.Write(numberTeens[2]);
                                break;
                            case 3:
                                Console.Write(numberTeens[3]);
                                break;
                            case 4:
                                Console.Write(numberTeens[4]);
                                break;
                            case 5:
                                Console.Write(numberTeens[5]);
                                break;
                            case 6:
                                Console.Write(numberTeens[6]);
                                break;
                            case 7:
                                Console.Write(numberTeens[7]);
                                break;
                            case 8:
                                Console.Write(numberTeens[8]);
                                break;
                            case 9:
                                Console.Write(numberTeens[9]);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.Write(numberEty[0]);
                        break;
                    case 3:
                        Console.Write(numberEty[1]);
                        break;
                    case 4:
                        Console.Write(numberEty[2]);
                        break;
                    case 5:
                        Console.Write(numberEty[3]);
                        break;
                    case 6:
                        Console.Write(numberEty[4]);
                        break;
                    case 7:
                        Console.Write(numberEty[5]);
                        break;
                    case 8:
                        Console.Write(numberEty[6]);
                        break;
                    case 9:
                        Console.Write(numberEty[7]);
                        break;
                    default:
                        break;
                }

                switch (numberInput % 10)
                {
                    case 0:
                        if (numberInput == 0)
                        {
                            Console.Write(zeroNineNumbers[0]);
                            break;
                        }
                        break;
                    case 1:
                        if (numberInput / 10 % 10 == 1)
                        {
                            break;
                        }
                        Console.Write(zeroNineNumbers[1]);
                        break;
                    case 2:
                        if (numberInput / 10 % 10 == 1)
                        {
                            break;
                        }
                        Console.Write(zeroNineNumbers[2]);
                        break;
                    case 3:
                        if (numberInput / 10 % 10 == 1)
                        {
                            break;
                        }
                        Console.Write(zeroNineNumbers[3]);
                        break;
                    case 4:
                        if (numberInput / 10 % 10 == 1)
                        {
                            break;
                        }
                        Console.Write(zeroNineNumbers[4]);
                        break;
                    case 5:
                        if (numberInput / 10 % 10 == 1)
                        {
                            break;
                        }
                        Console.Write(zeroNineNumbers[5]);
                        break;
                    case 6:
                        if (numberInput / 10 % 10 == 1)
                        {
                            break;
                        }
                        Console.Write(zeroNineNumbers[6]);
                        break;
                    case 7:
                        if (numberInput / 10 % 10 == 1)
                        {
                            break;
                        }
                        Console.Write(zeroNineNumbers[7]);
                        break;
                    case 8:
                        if (numberInput / 10 % 10 == 1)
                        {
                            break;
                        }
                        Console.Write(zeroNineNumbers[8]);
                        break;
                    case 9:
                        if (numberInput / 10 % 10 == 1)
                        {
                            break;
                        }
                        Console.Write(zeroNineNumbers[9]);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Number out of range!");
            }

            Main();
        }
    }
}



//namespace _11.Number_as_Words_1
//{
//    class NumberAsWords1
//    {
//        static void Main()
//        {
//            string hundred = " hundred";
//            string[] numberEty = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
//            string[] numberTeens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
//            string[] zeroNineNumbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//            string and = " and ";

//            Console.WriteLine();
//            Console.Write("Enter a number in range [0-999]:");
//            short numberInput = short.Parse(Console.ReadLine());
//            byte hundredFormula = (byte)((numberInput / 100));
//            byte numberEtyFormula = (byte)((numberInput / 10) % 10);
//            byte numbersToNineFormula = (byte)(numberInput % 10);

//            if (numberInput >= 0 && numberInput < 1000)
//            {
//                if (hundredFormula == 0) // 99 - 0
//                {
//                    if (numberEtyFormula == 0) // 9-0
//                    {
//                        Console.WriteLine(zeroNineNumbers[numbersToNineFormula]);
//                    }
//                    if (numberEtyFormula == 1) // 10 -19
//                    {
//                        Console.WriteLine(numberTeens[numbersToNineFormula]);
//                    }
//                    if (numberEtyFormula > 1 && numbersToNineFormula == 0) // 20-30-90
//                    {
//                        Console.WriteLine(numberEty[numberEtyFormula - 2]);
//                    }
//                    if (numberEtyFormula > 1 && numbersToNineFormula > 0) // 22-33-44-99
//                    {
//                        Console.WriteLine(numberEty[numberEtyFormula - 2] + zeroNineNumbers[numbersToNineFormula]);
//                    }
//                }
//                else // 100-999
//                {
//                    if (numberEtyFormula > 1 && numbersToNineFormula > 0) // 129 - 139 - 149
//                    {
//                        Console.WriteLine(zeroNineNumbers[hundredFormula] + hundred + numberEty[numberEtyFormula - 2] + zeroNineNumbers[numbersToNineFormula]);
//                    }
//                    if (numberEtyFormula == 0 && numbersToNineFormula == 0) // 100-200-900
//                    {
//                        Console.WriteLine(zeroNineNumbers[hundredFormula] + hundred);
//                    }
//                    if (numberEtyFormula > 1 && numbersToNineFormula == 0) // 110-220-990
//                    {
//                        Console.WriteLine(zeroNineNumbers[hundredFormula] + hundred + numberEty[numberEtyFormula - 2]);
//                    }
//                    if (numberEtyFormula == 1 && numbersToNineFormula >= 0) // 110-119
//                    {
//                        Console.WriteLine(zeroNineNumbers[hundredFormula] + hundred + and + numberTeens[numbersToNineFormula]);
//                    }
//                    if (numberEtyFormula < 1 && numbersToNineFormula > 0) // 101-109
//                    {
//                        Console.WriteLine(zeroNineNumbers[hundredFormula] + hundred + and + zeroNineNumbers[numbersToNineFormula]);
//                    }
//                }
//            }
//            else
//            {
//                Console.WriteLine("The number is out of range!");
//                Main();
//            }
//            Main();
//        }
//    }
//}