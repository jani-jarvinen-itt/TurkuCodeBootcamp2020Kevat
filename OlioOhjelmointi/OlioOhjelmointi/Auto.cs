using System;
using System.Collections.Generic;
using System.Text;

namespace OlioOhjelmointi
{
    class Auto
    {
        // ominaisuudet (property)
        public int Nopeus { get; set; }

        public int Huippunopeus { get; set; }

        public bool MoottoriKäynnissä { get; set; }

        public string Väri { get; set; }

        /*
        // rakentaja eli konstruktori (ei tässä tarpeen, muuttuja alustetaan automaattisesti)
        public Auto()
        {
            Nopeus = 0;
            MoottoriKäynnissä = false;
        }
        */

        // metodit eli toiminnot
        public void Käynnistä()
        {
            PyöritäStarttiMoottoria();
            MoottoriKäynnissä = true;
        }

        public void Sammuta()
        {
            MoottoriKäynnissä = false;
        }

        public void Kiihdytä()
        {
            Nopeus += 10;  // Nopeus = Nopeus + 10;
            if (Nopeus > Huippunopeus)
            {
                Nopeus = Huippunopeus;
            }
        }

        public void Jarruta()
        {
            Nopeus -= 10; // Nopeus = Nopeus - 10;
            if (Nopeus < 0)
            {
                Nopeus = 0;
            }
        }

        private void PyöritäStarttiMoottoria()
        {
        }
    }
}
