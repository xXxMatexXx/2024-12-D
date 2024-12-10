using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class RacingCar : Car
    {
        public void Mozgas_Ellenorzese()
        {
            this.MozogElore();

            if (this.x_poz == 40 && this.y_poz == 40 || this.x_poz == 20 && this.y_poz == 20)
            {
                Console.WriteLine($"Hiba, a(z) ({this.x_poz}, {this.y_poz}) koordinátákra nem jutott el a(z) azonosító {this.azonosito} számú versenyautó!!!");
                return;
            }

            Koordinata_Adat_Kiirasa();
        }

        public RacingCar(string azonosito, int speed_x, int speed_y) : base(azonosito, speed_x, speed_y)
        {

        }
    }
}
