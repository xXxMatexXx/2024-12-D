using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvtar_gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library konyvtar = new Library();

            konyvtar.KonyvHozzaadas("Cigiri", "Levi", "0000000000001", false, 2024, 9, 12);
   
            konyvtar.FelhasznaloHozzaadas("Gazsi", "75D");

            konyvtar.Kolcsonoz("75D", "0000000000001");
            
            konyvtar.FelhasznaloKonyvekMegjelenitese();

            Console.ReadKey();
        }
    }
}
