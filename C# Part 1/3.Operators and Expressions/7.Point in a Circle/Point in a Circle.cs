using System;

namespace _7.Point_in_a_Circle
{
    class PointinaCircle
    {
        static void Main()
        {
            Console.Write("Enter X:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            int y = int.Parse(Console.ReadLine());
            bool inCircle = (((x * x) + (y * y)) <= 2 * 2);
            Console.WriteLine(inCircle);
            Main();

        }
    }
}
