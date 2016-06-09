
using System;
namespace _3.Min__Max__Sum_and_Average_of_N_Numbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            double[] inputs = new double[number];
            double sum = 0;
            double average = 0;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " number");
                inputs[i] = double.Parse(Console.ReadLine());
                sum += inputs[i];
            }

            Array.Sort(inputs);
            Console.WriteLine("the smallest number is:{0}", inputs[0]);
            Console.WriteLine("the biggest number is:{0}", inputs[number - 1]);
            Console.WriteLine("the sum is:{0}", sum);
            average = sum / number;
            Console.WriteLine("average is:{0:F2}", average);


            Main();
        }
    }
}
