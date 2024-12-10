using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car
    {
        private int x_poz { get; set; }
        private int y_poz { get; set; }

        private string azonosito { get; set; }

        public void Mozog_Elore(int speed_x, int speed_y)
        {
            this.x_poz += speed_x;
            this.y_poz += speed_y;
            if (x_poz > 0 || y_poz > 0)
            {
                Console.WriteLine($"Ide mozgott a(z) {this.azonosito} azonosítóval rendelkező autó: ({this.x_poz}, {this.y_poz}) ");
            }
                
        }

        public Car(string azonosito)
        {
            this.azonosito = azonosito;
        }

    }
}
