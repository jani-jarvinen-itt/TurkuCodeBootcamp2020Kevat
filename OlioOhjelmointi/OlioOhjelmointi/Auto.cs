using System;
using System.Collections.Generic;
using System.Text;

namespace OlioOhjelmointi
{
    class Auto
    {
        // ominaisuudet
        public int Nopeus { get; set; }

        public bool MoottoriKäynnissä { get; set; }

        public string Väri { get; set; }

        // metodit eli toiminnot
        public void Käynnistä()
        {
            MoottoriKäynnissä = true;
        }

        public void Sammuta()
        {
            MoottoriKäynnissä = false;
        }
    }
}
