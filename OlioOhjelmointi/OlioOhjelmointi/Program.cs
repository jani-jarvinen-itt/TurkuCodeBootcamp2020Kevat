using System;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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

            Loki.Kirjoita("Sovelluksen suoritus päättyy");
            Console.ReadLine();
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
