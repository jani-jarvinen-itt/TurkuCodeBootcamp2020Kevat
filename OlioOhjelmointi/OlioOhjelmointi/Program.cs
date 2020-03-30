using System;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
        }

        static void Tulosta(Auto a)
        {
            Console.WriteLine("Auto: väri = " + a.Väri +
                ", nopeus = " + a.Nopeus +
                ", huippunopeus = " + a.Huippunopeus);
        }
    }
}
