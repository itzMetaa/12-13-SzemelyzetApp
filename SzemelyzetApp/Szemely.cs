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

        public Szemely Keres(string nev, DateTime szuletes)
        {
            if (this.nev.Equals(nev) && this.szuletes.Equals(szuletes))
            {
                return this;
            }
            foreach (var b in beosztottak)
            {
                var keresett = b.Keres(nev, szuletes);
                if (keresett != null)
                {
                    return keresett;
                }
            }
            return null;
        }

        public int Letszam
        {
            get
            {
                var l = 1;
                foreach (var b in beosztottak)
                {
                    l += b.Letszam;
                }
                return l;
            }
        }

        public void Listazas()
        {
            Console.WriteLine(this);
            foreach (var b in beosztottak)
            {
                b.Listazas();
            }
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

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", nev, beosztas, szuletes);
        }
    }
}
