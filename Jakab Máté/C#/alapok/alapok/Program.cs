﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cilusok
            /*
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i);
            }
            */

            /*
            for (int i = 1; i <= 50; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            int a = 1;
            while (a < 51) 
            {
                if (a % 3 == 0 && a % 5 == 0)
                {
                    Console.Write(a + " ");
                }
                a++;
            }
            */

            /*
            int a = 2;
            int b = 10;
            while (a < b - 1)
            {
                a++;
                Console.WriteLine(a);
            }
            */

            /*
            Console.Write("Add meg az a oldalt! ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Add meg az a oldalt! ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"A téglalap kerülete: {2 * (a + b)}");
            */

            /*
            List<int> list = new List<int>();

            Console.Write("Add meg az első számot! ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Add meg a második számot! ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Add meg a harmadik számot! ");
            int c = int.Parse(Console.ReadLine());

            list.Add(a);
            list.Add(b);
            list.Add(c);

            Console.WriteLine($"A legnagyobb szám: {list.Max()}");
            */

            //kiválasztás
            /*
            int[] numbers = { 2, 4, 1, 6, 5, 3};
            int i = 0;
            while (i < numbers.Length && numbers[i] % 2 == 0)
            {
                i++;
            }

            int idx = i;

            Console.WriteLine(idx);
            */

            //lineáris keresés
            /*
            int[] numbers = { 2, 4, 1, 6, 5, 3 };
            int i = 0;

            while (i < numbers.Length && numbers[i] % 2 == 0) 
            {
                i++;
            }

            bool van = i < numbers.Length;

            if (van)
            {
                int idx = i;
                Console.WriteLine($"{van}, {idx}");
            }

            else
            {
                Console.WriteLine(van);
            }
            */

            

        }

    }
}
