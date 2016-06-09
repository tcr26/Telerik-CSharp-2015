using System;

namespace _9.Sum_of_n_Numbers
{
    class SumofnNumbers
    {
        static void Main()
        {
            Console.Write("How many calculations do u want?:");
            ushort entries = ushort.Parse(Console.ReadLine());
            double result = 0;

            for (int i = 0; i < entries; i += 1)
            {
                result += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
        }
    }
}
