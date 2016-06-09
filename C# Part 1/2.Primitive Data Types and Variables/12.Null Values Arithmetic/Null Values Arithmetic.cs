using System;
namespace _12.Null_Values_Arithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? num1 = null;
            Console.WriteLine(num1);
            double? num2 = null;
            Console.WriteLine(num2);

            Console.WriteLine(num1 + 2);
            Console.WriteLine(num2 + 2);
        }
    }
}
