using System;
class Program
{
    static void Main()
    {
        Console.Write("enter number:");
        System.Console.SetWindowSize(100, 30);
        int n = int.Parse(Console.ReadLine());
        Console.Clear();
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        int value = 1;

        if (n > 0 && n < 21)
        {
            while (value <= n * n)
            {
                while (col < matrix.GetLength(0) && matrix[col, row] == 0)
                {
                    matrix[row, col++] = value;
                    value++;
                }
                col--;
                row++;
                while (row < matrix.GetLength(1) && matrix[row, col] == 0)
                {
                    matrix[row++, col] = value;
                    value++;
                }
                row--;
                col--;
                while (col >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col--] = value;
                    value++;
                }
                col++;
                row--;
                while (row >= 0 && matrix[row, col] == 0)
                {
                    matrix[row--, col] = value;
                    value++;
                }
                col++;
                row++;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j * 5, i * 2);
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}



//class SpiralMatrix
//{
//    static void Main()
//    {
//        Console.Write("Enter n: ");
//        int n = int.Parse(Console.ReadLine());
//        int[,] matrix = new int[n, n];
//        int row = 0;
//        int col = 0;
//        string direction = "right";
//        int maxRotations = n * n;

//        for (int i = 1; i <= maxRotations; i++)
//        {
//            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
//            {
//                direction = "down";
//                col--;
//                row++;
//            }
//            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
//            {
//                direction = "left";
//                row--;
//                col--;
//            }
//            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
//            {
//                direction = "up";
//                col++;
//                row--;
//            }

//            if (direction == "up" && row < 0 || matrix[row, col] != 0)
//            {
//                direction = "right";
//                row++;
//                col++;
//            }

//            matrix[row, col] = i;

//            if (direction == "right")
//            {
//                col++;
//            }
//            if (direction == "down")
//            {
//                row++;
//            }
//            if (direction == "left")
//            {
//                col--;
//            }
//            if (direction == "up")
//            {
//                row--;
//            }
//        }

//        // Display Matrix

//        for (int r = 0; r < n; r++)
//        {
//            for (int c = 0; c < n; c++)
//            {
//                Console.Write("{0,4}", matrix[r, c]);
//            }
//            Console.WriteLine();
//        }
//    }
//}