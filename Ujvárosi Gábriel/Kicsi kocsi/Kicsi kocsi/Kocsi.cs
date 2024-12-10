using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kicsi_kocsi
{

   
    public class Kocsi
    {
        
       
        public Kocsi(int azonosító)
        {
       //      string color = "RED";
            int x_cord = 0;
            int y_cord = 0;

            Forward(x_cord);
            int speed = azonosító;
/*
            if (irany == "Előre")
            {
                Forward(x_cord);
                    //speed); 

                
            } else if (irany == "Hátra")
            {
                Backward(x_cord);
                    //speed);
            } else
            {
                Console.WriteLine("Direction error");
                Console.ReadLine();
            }
*/

        }
        // Az autó előre mozgatása
        static void Forward(int x,

                                   int speed1)
        {

            // while (true)
            //  {
         //   x += 1;
                x = x + speed1;
                Console.WriteLine(x);

            //    }
            Console.ReadLine();
        }

        // Az autó Hárta mozgatása mozgatása
  /*      static void Backward(int x)
            //int speed1)
        {

            //  while (true)
            //   {
            x -= 1;
           // x = x - speed1;
                Console.WriteLine(x);
            //   }
            Console.ReadLine();
        }
  */


    }
}
