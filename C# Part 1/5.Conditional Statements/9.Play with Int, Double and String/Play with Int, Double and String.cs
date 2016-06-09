using System;

namespace _9.Play_with_Int__Double_and_String
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.WriteLine("1---> Int");
            Console.WriteLine("2---> Double");
            Console.WriteLine("3---> String");
            Console.Write("Your Choice is:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter a integer:");
                    int intInput = int.Parse(Console.ReadLine());
                    int integerNumber = intInput + 1;
                    Console.WriteLine(integerNumber);
                    break;
                case "2":
                    Console.Write("Enter a double:");
                    double doubleInput = double.Parse(Console.ReadLine());
                    double doubleNumber = doubleInput + 1;
                    Console.WriteLine(doubleNumber);
                    break;
                case "3":
                    Console.Write("Enter some text:");
                    string stringInput = Console.ReadLine();
                    Console.WriteLine(stringInput + "*");
                    break;
                default:
                    break;
            }

            //if (choice == "1")
            //{
            //    Console.Write("Enter a integer:");
            //    int intInput = int.Parse(Console.ReadLine());
            //    int integerNumber = intInput + 1;
            //    Console.WriteLine(integerNumber);
            //}
            //else if (choice == "2")
            //{
            //    Console.Write("Enter a double:");
            //    double doubleInput = double.Parse(Console.ReadLine());
            //    double doubleNumber = doubleInput + 1;
            //    Console.WriteLine(doubleNumber);
            //}
            //else if (choice == "3")
            //{
            //    Console.Write("Enter some text:");
            //    string stringInput = Console.ReadLine();
            //    Console.WriteLine(stringInput + "*");
            //}
            Main();
        }
    }
}
