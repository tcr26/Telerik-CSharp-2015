
using System;
namespace _4.Rectangles_Perimeter_Area
{
    class RectanglesPerimeterArea
    {
        static void Main()
        {
            Console.Write("1 for Area, 2 for Perimeter: ");
            byte choice = byte.Parse(Console.ReadLine());

            byte asd = choice;

            Console.Write("Enter Width:");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter Height");
            double height = double.Parse(Console.ReadLine());

            double area = (width * height);

            double perimeter = (width * 2) + (height * 2);

            if (choice == 1)
            {
                Console.WriteLine(area);
            }
            else if (choice == 2)
            {
                Console.WriteLine(perimeter);
            }
            Main();
        }
    }
}
