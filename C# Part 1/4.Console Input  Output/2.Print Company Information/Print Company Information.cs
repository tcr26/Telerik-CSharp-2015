using System;

namespace _2.Print_Company_Information
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Enter ur company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Enter company name address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Enter ur company phone number: ");
            int companyPhoneNumber = int.Parse(Console.ReadLine());

            Console.Write("enter ur company fax number");
            int companyFaxNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter companys website: ");
            string companyWebSite = Console.ReadLine();

            Console.Write("Enter company manager first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Enter company manager last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Enter company manager age: ");
            byte managerAge = byte.Parse(Console.ReadLine());

            Console.Write("Enter comapny manager phone number: ");
            int managerPhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Company name is {0}", companyName);
            Console.WriteLine("Company address is {0}", companyAddress);
            Console.WriteLine("Company phone number is {0}", companyPhoneNumber);
            Console.WriteLine("Company fax number is {0}", companyFaxNumber);
            Console.WriteLine("Company web site is {0}", companyWebSite);
            Console.WriteLine("Manager name is {0} {1}", managerFirstName, managerLastName);
            Console.WriteLine("Manager age is {0}", managerAge);
            Console.WriteLine("Manager phone number is {0}", managerPhoneNumber);

        }
    }
}
