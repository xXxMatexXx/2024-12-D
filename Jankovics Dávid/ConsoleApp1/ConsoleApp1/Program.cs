namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Ciklusok
            /*
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i);
            }
            */

            /*
            int szam = 0 ;

            while (szam != 3) 
            {
                szam++;
                Console.WriteLine(szam);
            }    
            */

            // Irassátok ki 1-től 50-ig a 3-mal és 5-tel osztható számokat!

            /*

            for (int i = 0; i < 51; i++) 
            {
                if (i % 3 == 0 &&  i % 5 == 0) 
                {
                    Console.Write(i + " ");
                }
            }
            */
            /*

            int a = 5;
            int b = 50;

            for (int i = a + 1; i < b; i++)
            {
                Console.Write(i + "    ");
            }
               

                */

            // bekérés a felhasználótol


            /*
            Console.Write("Kérek valamit: ");

            int beker = int.Parse(Console.ReadLine()); // ha csak számot akarok bekérni akkor int külömben stringben tárolom

            Console.WriteLine(beker);

            // int szam = int.Parse(beker);   ha késöbb akarjuk át alakítani

            Console.WriteLine( beker + 10);

            */
            /*

            //Kérje be a felhasználótól a téglalap oldalait
            // Számold ki a kerületet

            Console.Write("Add meg  a téglalap A oldalát: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Add meg  a téglalap B oldalát: ");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("A téglalap kerülete: " + (a + b) * 2);   
            */


            //A felhasználó megad 3 külömböző pozitív egész számot.
            //a program döntse el, hogy a 3 szám közül melyik a legnagyobb
            //A legnagyobb számot irja ki
            /*
            Console.Write("Addjon meg egy számot: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Addjon meg mégegy számot: ");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Addjon meg mégegy számot: ");

            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b);
            }
            else 
            {
                Console.WriteLine(c);
            }
            */




        }
    }
}
