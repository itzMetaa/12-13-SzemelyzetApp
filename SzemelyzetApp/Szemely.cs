using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyzetApp
{
    class Szemely : IComparable<Szemely>
    {
        readonly string nev;
        readonly DateTime szuletes;

        string beosztas;

        ISet<Szemely> beosztottak = new SortedSet<Szemely>();

        public Szemely(string nev, string beosztas, DateTime szuletes)
        {
            this.nev = nev;
            this.beosztas = beosztas;
            this.szuletes = szuletes;
        }

        public void Hozzaad(Szemely sz)
        {
            beosztottak.Add(sz);
        }

        public string Nev => nev;
        public DateTime Szuletes => szuletes;
        public string Beosztas { get => beosztas; set => beosztas = value; }

        public int CompareTo(Szemely other)
        {
            int i = this.nev.CompareTo(other.nev);
            if (i != 0)
            {
                return i;
            }
            return this.szuletes.CompareTo(other.szuletes);
        }
    }
}
