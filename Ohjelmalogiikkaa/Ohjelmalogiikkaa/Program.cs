using System;

namespace Ohjelmalogiikkaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            int j = 200;
            string s = "ABC";
            Console.WriteLine("Hello World!");

            if (i > 100)
            {
                if (i < 500)
                {
                    Console.WriteLine("I:n arvo on yli sata mutta alle 500.");
                }
                else
                {
                    Console.WriteLine("I:n arvo on yli 500.");
                }
            }
            else
            {
                Console.WriteLine("I:n arvo on sata tai alle.");
            }

            for (int laskuri = 0; laskuri < 10; laskuri++)
            {
                Console.WriteLine("Moikka!");
            }

            /*
            if (i > 100) Console.WriteLine("I:n arvo on yli sata.");
            else Console.WriteLine("I:n arvo on sata tai alle.");
            */
        }
    }
}
