using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kajak_kenuKolcsonzo
{
    internal class Kolcsonzes
    {
        public string Nev { get; set; }
        public int Azonosito { get; set; }
        public string Tipus { get; set; }
        public int SzemelyekSzama { get; set; }
        public int ElvitelOraja{ get; set; }
        public int ElvitelPerce{ get; set; }
        public int VisszahozatalOraja{ get; set; }
        public int VisszahozatalPerc{ get; set; }

        public Kolcsonzes(string sor)
        {
            var s = sor.Split(";");
            Nev = s[0];
            Azonosito = int.Parse(s[1]);
            Tipus = s[2];
            SzemelyekSzama = int.Parse(s[3]);
            ElvitelOraja = int.Parse(s[4]);
            ElvitelPerce = int.Parse(s[5]);
            VisszahozatalOraja = int.Parse(s[6]);
            VisszahozatalPerc = int.Parse(s[7]);
        }

    }
}
