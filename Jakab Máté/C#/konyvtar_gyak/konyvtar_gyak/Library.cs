using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvtar_gyak
{
    public class Library
    {
        public List<Book> Konyvek = new List<Book>();

        private List<User> Felhasznalok = new List<User>();

        //Könyv lista tartalmának kiirása
        public void KonyvMegjelenites()
        {
            foreach (Book book in Konyvek) 
            {
                Console.WriteLine($"Cím: {book.Cim}, Szerző: {book.Szerzo}, ISBN: {book.Isbn}, Kiadási dátum: {book.KiadasiDatum.ToString("yyyy.MM.dd")}, Kölcsönözve: {book.Kolcsonozve}");
            }
        }

        //Felhasználó lista tartalmának kiirása
        public void FelhasznaloMegjelenites()
        {
            foreach (User user in Felhasznalok)
            {
                Console.WriteLine($"Név: {user.Nev}, FelhasználóID: {user.FelhasznaloID}");
            }
        }

        public void FelhasznaloKonyvekMegjelenitese()
        {
            foreach(User felhasznalo in Felhasznalok)
            {
                foreach(Book kolcsonzottkonyv in felhasznalo.KolcsonzottKonyvek)
                {
                    Console.WriteLine("Kölcönzött Könyvek:");
                    Console.WriteLine($"Cím: {kolcsonzottkonyv.Cim}, Szerző: {kolcsonzottkonyv.Szerzo}, ISBN: {kolcsonzottkonyv.Isbn}, Kiadási dátum: {kolcsonzottkonyv.KiadasiDatum.ToString("yyyy.MM.dd")}, Kölcsönözve: {kolcsonzottkonyv.Kolcsonozve}");
                    Console.WriteLine();
                }
            }
        }

        //Hozzáadunk egy könyvet a könyvtárhoz
        public void KonyvHozzaadas(string cim, string szerzo, string isbn, bool kolcsonozve, int Kiadas_eve, int Kiadas_honapja, int Kiadas_napja)
        {
            var konyv = new Book
            {
                Cim = cim,
                Szerzo = szerzo,
                Isbn = isbn,
                KiadasiDatum = new DateTime(Kiadas_eve, Kiadas_honapja, Kiadas_napja),
                Kolcsonozve = kolcsonozve
            };

            Konyvek.Add(konyv);
        }

        //Hozzáadunk egy felhasználót a listához
        public void FelhasznaloHozzaadas(string nev, string felhasznaloid)
        {
            var felhasznalo = new User
            {
                Nev = nev,
                FelhasznaloID = felhasznaloid
            };

            Felhasznalok.Add(felhasznalo);
        }

        public void Kolcsonoz(string felhasznaloid, string isbn)
        {
            bool tud_kolcsonozni = false;

            foreach(User user in Felhasznalok)
            {
                if (user.FelhasznaloID == felhasznaloid)
                {
                    tud_kolcsonozni = true;

                    if (tud_kolcsonozni)
                    {
                        foreach (Book konyv in Konyvek)
                        {
                            if (konyv.Isbn == isbn)
                            {
                                konyv.Kolcsonozve = true;
                                user.KolcsonzottKonyvek.Add(konyv);
                            }
                        }
                    }
                }
            }

            
        }
    }
}
