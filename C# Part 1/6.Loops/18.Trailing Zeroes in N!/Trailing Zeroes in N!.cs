using System;
using System.Numerics;

namespace _18.Trailing_Zeroes_in_N_
{
    class TrailingZeroesInN
    {
        static void Main()
        {
            Console.Write("Enter number:");
            BigInteger input = BigInteger.Parse(Console.ReadLine());

            BigInteger result = factorial(input);
            BigInteger zeroCounted = input / 5;

            Console.WriteLine("in factorial of {0} there is {1} trailing zeroes", result, zeroCounted);
            Main();
        }

        private static BigInteger factorial(BigInteger number)
        {

            if (number <= 1)
            {
                return 1;
            }

            return number * factorial(number - 1);
        }
    }
}


//"Броят на нулите в края на n! зависи от това, колко пъти числото 10 е делител на факториела. Понеже произведението 1*2*3…*n има повече на брой делители 2, отколкото 5, а 10 = 2 * 5, то броят нули в n! е точно толкова, колкото са множителите със стойност 5 в произведението 1*2*3….*n. Понеже всяко пето число се дели на 5, а всяко 25-то число се дели на 5 двукратно и т.н., то броя нули в n! е сумата: n/5 + n/25 + n/125 + … " 
