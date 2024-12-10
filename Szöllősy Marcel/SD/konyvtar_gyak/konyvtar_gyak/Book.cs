using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvtar_gyak
{
    public class Book
    {
        public string Cim {  get; set; }
        public string Szerzo { get; set; }

        public string Isbn { get; set; }
        public DateTime KiadasiDatum { get; set; }

        public bool Kolcsonozve { get; set; }


    }
}
