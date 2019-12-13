using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyzetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fonok = new Szemely("Szultán", "szultán", new DateTime(864, 11, 12));

            var szemelyzet = new Szemelyzet(fonok);

            var jazmin = new Szemely("Jázmin", "hercegnő", new DateTime(880, 5, 12));
            var jafar = new Szemely("Jafar", "főtanácsadó", new DateTime(856, 12, 5));
            var iago = new Szemely("Iago", "papagáj", new DateTime(881, 1, 1));

            fonok.Hozzaad(jazmin);
            fonok.Hozzaad(jafar);
            jafar.Hozzaad(iago);

            Szemely keresett = szemelyzet.Keres("Jafar", new DateTime(856, 12, 5));
            Console.WriteLine(keresett);
            Console.WriteLine(szemelyzet.Letszam);

            Console.ReadLine();
        }
    }
}
