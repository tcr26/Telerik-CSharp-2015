using System;

namespace _9.Age_After_10_Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.Write("Enter Your Birth Year:");
            int birthYear = int.Parse(Console.ReadLine());
            DateTime current = DateTime.Now;
            int currentYear = current.Year;
            int result = (currentYear + 10) - birthYear;
            Console.WriteLine("After 10 years you will be: " + result);
            Main();
        }
    }
}
