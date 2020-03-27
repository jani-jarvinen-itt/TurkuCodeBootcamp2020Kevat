using System;

namespace Ohjelmalogiikkaa
{
    class Program
    {
        static void Main(string[] args)
        {
            // pelivakiot
            const int SuurinLuku = 20;
            const int ArvauskertojenMaksimiMäärä = 5;

            // aloitetaan peli ja arvotaan oikea numero
            Console.WriteLine("Arvaa luku -peli alkaa.");
            Random satunnaisluku = new Random();
            int oikea = satunnaisluku.Next(1, SuurinLuku + 1);
            // Console.WriteLine("Oikea: " + oikea);

            // aloitetaan silmukka, jossa kysytään pelaajan arvaukset
            for (int arvauskerrat = 1; arvauskerrat <= ArvauskertojenMaksimiMäärä; arvauskerrat++)
            {
                // kysytään numeerista syötettä niin kauan kunnes syöte on numero
                int arvaus;
                bool numeerinen;
                do
                {
                    Console.WriteLine($"Anna arvauksesi välillä 1-{SuurinLuku}:");
                    string syöte = Console.ReadLine();
                    numeerinen = int.TryParse(syöte, out arvaus);
                }
                while (!numeerinen);    // while (numeerinen == false);

                // tarkistetaan, arvasiko pelaaja oikein
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
