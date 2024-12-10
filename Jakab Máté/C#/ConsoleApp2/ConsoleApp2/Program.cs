using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car kocsi1 = new Car("029674");
            Car kocsi2 = new Car("956105");

            kocsi1.Mozog_Elore(12, 0);
            kocsi2.Mozog_Elore(20, 12);

            Console.ReadKey();
        }
    }
}
