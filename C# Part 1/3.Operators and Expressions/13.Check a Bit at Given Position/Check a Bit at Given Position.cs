using System;

namespace _13.Check_a_Bit_at_Given_Position
{
    class CheckaBitatGivenPosition
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            //int mask = 1;
            bool id = (n & (1 << p)) > 0;
            Console.WriteLine(id);
            //uint mask = 1;        
            //Console.WriteLine((mask << p & n) > 0 ? false: true);
            Main();
        }
    }
}
