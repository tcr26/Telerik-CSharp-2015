using System;

namespace _3.Circle_Perimeter_and_Area
{
    class CirclePerimeterandArea
    {
        static void Main()
        {
            Console.WriteLine("Enter radius of the circle: ");
            float radius = float.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * (Math.PI * radius);

            Console.WriteLine("Choose 1 for circle area and 2 for circle perimeter: ");
            byte choose = byte.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Console.WriteLine("{0:0.00}", area);
            }
            else if (choose == 2)
            {
                Console.WriteLine("{0:0.00}", perimeter);
            }
            Main();
        }
    }
}
