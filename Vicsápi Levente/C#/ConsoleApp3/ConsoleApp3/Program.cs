using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            RacingCar kocsi1 = new RacingCar("956412", 20, 12);
            RacingCar kocsi2 = new RacingCar("956517", 20, 20);

            kocsi1.Mozgas_Ellenorzese();
            kocsi2.Mozgas_Ellenorzese();

            Console.ReadKey();
        }
    }
}
