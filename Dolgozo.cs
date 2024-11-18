using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek2020
{
    internal class Dolgozo
    {
        public string Nev { get; set; }
        public string Nem { get; set; }
        public string Reszleg { get; set; }
        public int Belepes { get; set; }
        public int Ber { get; set; }

        public Dolgozo(string sor)
        {
            string[] v = sor.Split(';');
            Nev = v[0];
            Nem = v[1];
            Reszleg = v[2];
            Belepes = int.Parse(v[3]);
            Ber = int.Parse(v[4]);
        }
    }
}
