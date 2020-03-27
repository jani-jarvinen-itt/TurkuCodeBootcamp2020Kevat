using System;

namespace Ohjelmalogiikkaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arvaa luku -peli alkaa.");
            Random satunnaisluku = new Random();
            int oikea = satunnaisluku.Next(1, 20 + 1);
            // Console.WriteLine("Oikea: " + oikea);

            for (int arvauskerrat = 1; arvauskerrat <= 5; arvauskerrat++)
            {
                Console.WriteLine("Anna arvauksesi välillä 1-20:");
                int arvaus = int.Parse(Console.ReadLine());
                if (arvaus < oikea)
                {
                    Console.WriteLine("Oikea luku on suurempi.");
                }
                else if (arvaus > oikea)
                {
                    Console.WriteLine("Oikea luku on pienempi.");
                }
                else
                {
                    Console.WriteLine("Arvasit oikein!");
                    break;
                }
            }

            Console.WriteLine("Peli on päättynyt.");

            /*
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
            */

            /*
            if (i > 100) Console.WriteLine("I:n arvo on yli sata.");
            else Console.WriteLine("I:n arvo on sata tai alle.");
            */
        }
    }
}
