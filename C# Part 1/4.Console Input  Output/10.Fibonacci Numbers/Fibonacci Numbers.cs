using System;

namespace _10.Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter how many fibonacci sequences u want:");
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write(a + " " + b + " ");
            for (int i = 0; i < (number - 2); i += 1)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c + " ");
            }
            Main();
        }
    }
}
