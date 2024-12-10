using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvtar_gyak
{
    public class User
    {
        public string Nev { get; set; }
        public string FelhasznaloID { get; set; }

        public List<Book> KolcsonzottKonyvek = new List<Book>();
    }
}
