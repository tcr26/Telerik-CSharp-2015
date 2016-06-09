using System;
using System.Text;
namespace _8.Isosceles_Triangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char copyright = '\u00A9';
            int thighLength = 4;
            for (int i = 1; i <= thighLength; i++)
            {
                Console.Write(new string(' ', thighLength - i)); // add white spaces

                for (int j = 1; j <= i; j++)
                {
                    if (i == 3 && j == 2)
                    {
                        Console.Write("{0} ", " ");
                    }
                    else
                    {
                        Console.Write("{0} ", copyright);
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }

}
