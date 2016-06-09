using System;
using System.Collections.Generic;

namespace _11.Bank_Account_Data
{
    class BankAccountData
    {
        static void Main()
        {
            List<object> bankData = new List<object>();

            Console.Write("Enter ur first name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter ur last name: ");
            string lName = Console.ReadLine();

            Console.Write("Bank Name:");
            string bankName = Console.ReadLine();

            Random money = new Random();
            int acc = money.Next();



            bankData.Add(fName);
            bankData.Add(lName);
            bankData.Add(bankName);
            bankData.Add(acc);

            foreach (var dates in bankData)
            {
                Console.WriteLine(dates);
            }
        }
    }
}
