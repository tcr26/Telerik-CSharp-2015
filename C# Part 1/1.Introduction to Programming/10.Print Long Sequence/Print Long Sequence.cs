using System;

namespace _10.Print_Long_Sequence
{
    class Print_Long_Sequence
    {
        static void Main()
        {
            for (int i = 1; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * -1);
                }
            }
        }
    }
}
