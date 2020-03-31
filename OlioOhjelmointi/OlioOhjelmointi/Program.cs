using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // List<int> luvut = new List<int>(new int[] { 1, 2, 3, 4, 5 });
            List<Auto> autot = new List<Auto>();

            autot.Add(new Auto()
            {
                Väri = "Sininen",
                Huippunopeus = 250,
                MoottoriKäynnissä = false
            });
            autot.Add(new Auto()
            {
                Väri = "Harmaa",
                Huippunopeus = 220,
                MoottoriKäynnissä = false
            });

            autot.RemoveAt(0);

            autot.Add(new KuormaAuto()
            {
                Väri = "Valkoinen",
                Kantavuus = 25
            });

            // LaskeNumeroidenSumma();

            /*
            FileStream virta = new FileStream("C:\\Temp\\Päivämäärä.txt",
                FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Console.WriteLine("1: Try-lohko alkaa");
            try
            {
                byte[] tavut = Encoding.UTF8.GetBytes("Moi maailma!\r\n");
                virta.Write(tavut);

                Console.WriteLine("Anna päivämäärä ja mahdollinen kellonaika:");
                string syöte = Console.ReadLine();
                DateTime pvm = DateTime.Parse(syöte);

                CultureInfo fi = new CultureInfo("fi");
                string suomalainenPvm = pvm.ToString(fi);
                tavut = Encoding.UTF8.GetBytes(suomalainenPvm);
                virta.Write(tavut);

                Console.WriteLine("2: Try-lohko päättyy");
            }
            catch
            {
                Console.WriteLine("2 B: Catch-lohkossa");
            }
            finally
            {
                Console.WriteLine("3: Finally-lohko");
                virta.Close();
            }

            Console.WriteLine("4: Sovellus päättyy");
            Console.ReadLine();
            */

            /*
            Console.WriteLine("Anna päivämäärä ja mahdollinen kellonaika:");
            string syöte = Console.ReadLine();
            Console.WriteLine("Anna maa (esim. \"fi\"):");
            string maa = Console.ReadLine();

            CultureInfo kulttuuri = new CultureInfo(maa);
            DateTime pvm = DateTime.Parse(syöte, kulttuuri);
            CultureInfo fi = new CultureInfo("fi");
            Console.WriteLine(pvm.ToString(fi));
            Console.ReadLine();
            */

            /*
            DateTime nyt = DateTime.Now;
            DateTime utcAika = DateTime.UtcNow;

            Console.WriteLine(nyt);
            Console.WriteLine(utcAika);

            CultureInfo enUs = new CultureInfo("en-US");
            Console.WriteLine("-----");
            Console.WriteLine(nyt.ToString(enUs));

            CultureInfo es = new CultureInfo("es");
            CultureInfo en = new CultureInfo("en-GB");
            CultureInfo fr = new CultureInfo("fr");
            CultureInfo dk = new CultureInfo("dk");
            CultureInfo de = new CultureInfo("de");
            Console.WriteLine("ES: " + nyt.ToString(es));
            Console.WriteLine("EN: " + nyt.ToString(en));
            Console.WriteLine("FR: " + nyt.ToString(fr));
            Console.WriteLine("DK: " + nyt.ToString(dk));
            Console.WriteLine("DE: " + nyt.ToString(de));
            */

            /*
            Console.WriteLine("Anna desimaaliluku:");
            CultureInfo enUs = new CultureInfo("en-US");
            string syöte = Console.ReadLine();
            float luku = float.Parse(syöte, enUs);
            Console.WriteLine(luku.ToString(enUs));
            */


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

        private static void LaskeNumeroidenSumma()
        {
            List<int> luvut = LueNumerotKäyttäjänSyötteestä();

            int summa = 0;
            foreach (int luku in luvut)
            {
                summa += luku;
            }

            Console.WriteLine($"Yhteensä {luvut.Count} luvun summa on {summa}.");
        }

        private static List<int> LueNumerotKäyttäjänSyötteestä()
        {
            List<int> luvut = new List<int>();
            do
            {
                try
                {
                    Console.WriteLine("Anna laskettava luku tai tyhjä lopettaaksesi:");
                    string syöte = Console.ReadLine();
                    int luku = int.Parse(syöte);

                    luvut.Add(luku);
                }
                catch
                {
                    break;
                }
            }
            while (true);

            return luvut;
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
