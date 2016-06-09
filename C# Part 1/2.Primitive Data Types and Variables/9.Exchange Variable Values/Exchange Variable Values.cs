using System;

namespace _9.Exchange_Variable_Values
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            Console.WriteLine(a);
            int b = 10;
            Console.WriteLine(b);

            int tempNumber = b;
            b = a;
            Console.WriteLine(b);
            a = tempNumber;
            Console.WriteLine(a);

            //if (a == 5)
            //{
            //    a = 10;
            //    Console.WriteLine(a);
            //}
            //if (b == 10)
            //{
            //    b = 5;
            //    Console.WriteLine(b);
            //}


        }
    }
}
