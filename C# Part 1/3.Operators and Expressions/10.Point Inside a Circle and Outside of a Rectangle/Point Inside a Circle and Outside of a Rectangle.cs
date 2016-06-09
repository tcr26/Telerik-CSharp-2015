using System;

namespace _10.Point_Inside_a_Circle_and_Outside_of_a_Rectangle
{
    class PointInsideaCircleAndOutsideofaRectangle
    {
        static void Main()
        {
            Console.Write("Enter side x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter side y:");
            double y = double.Parse(Console.ReadLine());

            bool inCircle = (Math.Pow(x - 1, 2) + (Math.Pow(y - 1, 2)) <= 1.5 * 1.5);
            bool inRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);

            if (!inRectangle && inCircle)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Main();
        }
    }
}
