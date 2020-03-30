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
            oma.Käynnistä();

            Auto naapurin = new Auto();
            naapurin.Väri = "Harmaa";
            naapurin.Käynnistä();
        }
    }
}
