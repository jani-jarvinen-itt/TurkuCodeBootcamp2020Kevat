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

            Auto naapurin = new Auto();
            naapurin.Väri = "Harmaa";
            naapurin.Huippunopeus = 190;
            naapurin.Käynnistä();
        }
    }
}
