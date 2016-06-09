using System;

namespace _5.Square_Root
{
    class SquareRoot
    {
        static void Main()
        {
            Console.Write("Enter root numbers: ");
            var root = int.Parse(Console.ReadLine());
            var calculate = (float)Math.Sqrt(root);
            Console.WriteLine(calculate);
        }
    }
}
