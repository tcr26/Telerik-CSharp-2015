using System;

namespace _2.Gravitation_on_the_Moon
{
    class GravitationontheMoon
    {
        static void Main()
        {
            Console.Write("Enter ur weight:");
            double number = double.Parse(Console.ReadLine());
            double percentage = (number * 17) / 100;
            Console.WriteLine("Ur weight on the moon is: {0}", percentage);
            Main();
        }
    }
}
