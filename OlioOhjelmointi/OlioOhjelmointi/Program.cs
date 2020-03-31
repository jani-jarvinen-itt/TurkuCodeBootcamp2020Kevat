using System;
using System.IO;
using System.Text;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte b1 = 250;
            byte b2 = 100;

            int summa = b1 + b2;
            Console.WriteLine(summa); // tulostaa 350

            byte summa2 = (byte)(b1 + b2); // tyyppimuunnos, type cast
            Console.WriteLine(summa2); // tulostaa 94


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
