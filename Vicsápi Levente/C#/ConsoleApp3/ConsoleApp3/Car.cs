using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Car
    {
        protected int speed_x { get; set; }

        protected int speed_y { get; set; }
        protected int x_poz {  get; set; }
        protected int y_poz { get; set; }

        protected string azonosito { get; set; }

        
        public void MozogElore()
        {
             this.x_poz += speed_x;
             this.y_poz += speed_y;   
        }

        public void Koordinata_Adat_Kiirasa()
        {
            Console.WriteLine($"A(z) {this.azonosito} azonosító számú autó ezekre a koordinátákra mozgott: ({this.x_poz}, {this.y_poz})");
        }

        public Car(string azonosito, int speed_x, int speed_y) 
        { 
            this.azonosito = azonosito;
            this.speed_x = speed_x;
            this.speed_y = speed_y;
        }
    }
}
