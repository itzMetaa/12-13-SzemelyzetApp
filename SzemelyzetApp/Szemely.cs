using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyzetApp
{
    class Szemely
    {
        string nev;
        string beosztas;
        DateTime szuletes;

        ISet<Szemely> beosztottak = new SortedSet<Szemely>();

        public Szemely(string nev, string beosztas, DateTime szuletes)
        {
            this.nev = nev;
            this.beosztas = beosztas;
            this.szuletes = szuletes;
        }


    }
}
