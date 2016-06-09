using System;
using System.Collections.Generic;
namespace _10.Employee_Data
{
    class EmployeeData
    {
        static void Main()
        {
            List<object> emplData = new List<object>();

            Console.Write("Enter ur first name here:");
            string fName = Console.ReadLine();

            Console.Write("Enter ur last name here:");
            string lName = Console.ReadLine();

            string sex = "";
            Console.Write("Enter ur sex here:{0}", sex);
            string sexCheck = Console.ReadLine();

            if (sexCheck == "m")
            {
                sex = "Male";
            }
            else if (sexCheck == "f")
            {
                sex = "Female";
            }

            Console.Write("Enter ur id:");
            byte iD = byte.Parse(Console.ReadLine());

            emplData.Add(fName);
            emplData.Add(lName);
            emplData.Add(sex);
            emplData.Add(iD);

            foreach (var paket in emplData)
            {
                Console.WriteLine(paket);
            }
        }
    }
}
