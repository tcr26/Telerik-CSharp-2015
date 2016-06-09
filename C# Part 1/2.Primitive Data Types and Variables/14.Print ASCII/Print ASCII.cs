using System;
using System.Text;

namespace _14.Print_ASCII
{
    class PrintASCII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (byte i = 0; i < 255; i += 1)
            {
                Console.WriteLine("{0}-->{1}", i, (char)i);
            }
        }
    }
}
