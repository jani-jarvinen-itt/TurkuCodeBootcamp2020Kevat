using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Anna desimaaliluku:");
            CultureInfo enUs = new CultureInfo("en-US");
            string syöte = Console.ReadLine();
            float luku = float.Parse(syöte, enUs);
            Console.WriteLine(luku.ToString(enUs));

            Console.ReadLine();

            // float luku2 = 123.45f;

            /*
            int luku1 = 123;
            Int32 luku2 = 234;

            double liuku1 = 1.234;
            Double liuku2 = 2.345;

            string merkkijono1 = "ABC";
            String merkkijono2 = "BCD";
            */

            /*
            string nimi = "Jaska Jokunen";
            char merkki = 'A';

            nimi = nimi + "!";
            Console.WriteLine(nimi);
            */

            /*
            Console.WriteLine("Aloitetaan merkkijonon muodostaminen...");
            DateTime alku = DateTime.Now;
            string html = "<table class=\"table...\">";
            for (int i = 0; i < 100000; i++)
            {
                html += "<tr><td>Testi</td><td>...</td></tr>";
            }
            DateTime loppu = DateTime.Now;
            Console.WriteLine("Merkkijono on valmis, pituus = " + html.Length);
            double sekunnit = (loppu - alku).TotalSeconds;
            Console.WriteLine("Operaatio kesti: " + sekunnit + " sekuntia.");
            */

            /*
            Console.WriteLine("Aloitetaan merkkijonon muodostaminen StringBuilderilla...");
            DateTime alku = DateTime.Now;
            StringBuilder html = new StringBuilder("<table class=\"table...\">");
            for (int i = 0; i < 100000; i++)
            {
                html.Append("<tr><td>Testi</td><td>...</td></tr>");
            }
            string lopullinenHtml = html.ToString();
            DateTime loppu = DateTime.Now;
            Console.WriteLine("Merkkijono on valmis, pituus = " + lopullinenHtml.Length);
            double sekunnit = (loppu - alku).TotalSeconds;
            Console.WriteLine("Operaatio kesti: " + sekunnit + " sekuntia.");
            */

            /*
            byte b1 = 250;
            byte b2 = 100;

            int summa = b1 + b2;
            Console.WriteLine(summa); // tulostaa 350

            byte summa2 = (byte)(b1 + b2); // tyyppimuunnos, type cast
            Console.WriteLine(summa2); // tulostaa 94

            float f1 = 0.001f;
            float f2 = 0.9876f;
            float osamäärä = f1 / f2;
            Console.WriteLine(osamäärä);

            // liukulukujen vertailu
            if (Math.Abs(f1-f2) < 0.0001)
            {

            }
            */

            /*
            Loki.Kirjoita("Sovellus käynnistyy");

            Auto oma = new Auto();
            oma.Väri = "Punainen";
            oma.Huippunopeus = 240;
            oma.Käynnistä();
            oma.Kiihdytä();
            Tulosta(oma);

            Auto naapurin = new Auto();
            naapurin.Väri = "Harmaa";
            naapurin.Huippunopeus = 190;
            naapurin.Käynnistä();
            Tulosta(naapurin);

            KuormaAuto kuarkki = new KuormaAuto();
            kuarkki.Väri = "Sininen";
            kuarkki.Huippunopeus = 110;
            kuarkki.Kantavuus = 40;
            kuarkki.NostaLava();

            Tulosta(kuarkki);

            Loki.Kirjoita("Aloitetaan silmukka...");
            Console.ReadLine();
            for (int i = 0; i < 10000000; i++)
            {
                TestaaOlioita();
            }


            FileStream virta = new FileStream("C:\\Temp\\Tiedosto.txt",
                FileMode.OpenOrCreate, FileAccess.ReadWrite);
            byte[] tavut = Encoding.UTF8.GetBytes("Moi maailma!");
            virta.Write(tavut);
            // virta.Close();


            Loki.Kirjoita("Sovelluksen suoritus päättyy");
            Console.ReadLine();
            */
        }

        static void Tulosta(Auto a)
        {
            Loki.Kirjoita("Tulostetaan auto ruudulle");
            Console.WriteLine("Auto: väri = " + a.Väri +
                ", nopeus = " + a.Nopeus +
                ", huippunopeus = " + a.Huippunopeus);
        }

        static void TestaaOlioita()
        {
            Auto a = new Auto(); // muistinkulutus n. 50 tavua
            a.Väri = "Keltainen";
            a.Huippunopeus = 220;
        }
    }
}
