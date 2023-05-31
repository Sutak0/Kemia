using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Adatok
    {
        public string Ev;
        public string Nev;
        public string Vegyjel;
        public int Rendszam;
        public string Felfedezo;

        public Adatok() {
            
            string[] adatok = x.Split(";");
            this.Ev = adatok[0];
            this.Nev = adatok[1];
            this.Vegyjel = adatok[2];
            this.Rendszam = Convert.ToInt32(adatok[3]);
            this.Felfedezo = (adatok[4]);

        
        }
    }
}
