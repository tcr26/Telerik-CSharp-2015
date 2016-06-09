using System;

namespace _14.Modify_a_Bit_at_Given_Position
{
    class ModifyaBitatGivenPosition
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            if (v == 0)
            {
                n = n & ~(1 << p);
            }
            else
            {
                n = n | (1 << p);
            }
            Console.WriteLine(n);
            Main();
        }
    }
}
