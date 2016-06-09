
using System;
namespace _5.Boolean_Variable
{
    class BooleanVariable
    {
        static void Main()
        {
            bool gender;
            Console.Write("Are u a Female? Y or N: ");
            string answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
            {
                gender = true;
                Console.WriteLine(gender);
            }
            else
            {
                gender = false;
                Console.WriteLine(gender);
            }

        }
    }
}
