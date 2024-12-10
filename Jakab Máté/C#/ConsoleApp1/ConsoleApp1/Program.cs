using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 first = new Class1();
            Class2 second = new Class2();
            Class3 third = new Class3();

            
            Console.Write($"Adja meg az első nevet: ");
            first.SetName(Console.ReadLine());
            Console.Write($"Adja meg  {first.GetName()} korát: ");
            first.SetAge(Console.ReadLine());
            Console.Write($"Adja meg {first.GetName()} telefonszámát: ");
            first.SetPhone(Console.ReadLine());

            Console.Write($"Adja meg az második nevet: ");
            second.SetName(Console.ReadLine());
            Console.Write($"Adja meg  {second.GetName()} korát: ");
            second.SetAge(Console.ReadLine());
            Console.Write($"Adja meg {second.GetName()} telefonszámát: ");
            second.SetPhone(Console.ReadLine());

            Console.Write($"Adja meg az harmadik nevet: ");
            third.SetName(Console.ReadLine());
            Console.Write($"Adja meg  {third.GetName()} korát: ");
            third.SetAge(Console.ReadLine());
            Console.Write($"Adja meg {third.GetName()} telefonszámát: ");
            third.SetPhone(Console.ReadLine());

            string response;

            do
            {
                Console.Write($"Adja meg mennyit menjen {first.GetName()} előre: ");
                first.going(Console.ReadLine());
                Console.Write($"Adja meg mennyit menjen {second.GetName()} előre: ");
                second.going(Console.ReadLine());
                Console.Write($"Adja meg mennyit menjen {third.GetName()} előre: ");
                third.going(Console.ReadLine());

                response = Console.ReadLine().ToUpper();

            } while (response == "Y");

            Console.WriteLine("\nAz eddig bevitt adatok: ");
            Console.WriteLine(first.GetName()+ " előre ment: " + first.getAllDistance() + "méter");
            Console.WriteLine(second.GetName() + " előre ment: " + second.getAllDistance() + "méter");
            Console.WriteLine(third.GetName() + " előre ment: " + third.getAllDistance() + "méter");

            Console.WriteLine("Program vége");
            Console.ReadKey();
        }
    }
}
