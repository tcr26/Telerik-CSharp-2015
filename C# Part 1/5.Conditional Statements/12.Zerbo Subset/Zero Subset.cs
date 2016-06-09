using System;

namespace _12.Zerbo_Subset
{
    class ZeroSubset
    {
        static void Main()
        {
            int result;
            bool check = false;
            int[] input = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\nEnter a value for number " + (i + 1) + " : ");
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();


            for (int start = 0; start < 5; start++)
            {
                result = 0;

                for (int end = start; end < 5; end++)
                {
                    result = result + input[end];

                    if (result == 0)
                    {

                        check = true;
                        Console.WriteLine();

                        for (int i = start; i < end; i++)
                        {
                            Console.Write("{0} + ", input[i]);
                        }
                        Console.Write(input[end]);
                        Console.Write(" = 0\n\n");
                    }
                }
            }
            if (check == false)
            {
                Console.WriteLine();
                Console.WriteLine("no zero subset\n\n");

            }
            Main();
        }
    }
}
