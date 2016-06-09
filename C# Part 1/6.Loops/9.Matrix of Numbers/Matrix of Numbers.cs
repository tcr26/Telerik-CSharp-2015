using System;

namespace _9.Matrix_of_Numbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("enter n number:");
            uint matrix = uint.Parse(Console.ReadLine());

            for (int row = 1; row <= matrix; row += 1)
            {
                for (int col = row; col < matrix + row; col += 1)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
