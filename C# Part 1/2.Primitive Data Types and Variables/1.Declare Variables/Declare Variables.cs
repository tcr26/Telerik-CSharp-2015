using System;
namespace _1.Declare_Variables
{
    class Program
    {
        static void Main()
        {
            byte smallNumber = 97;
            sbyte negativeSmallNumber = -15;
            ushort bigNumber = 52130;
            short negativeBigNumber = -10000;
            uint largeNumber = 4825932;

            Console.WriteLine("{0} {1} {2} {3} {4}", smallNumber, negativeSmallNumber, bigNumber, negativeBigNumber, largeNumber);
        }
    }
}
