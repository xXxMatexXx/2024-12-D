﻿namespace Csak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            //Ciklusok
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            int szam = 0;
            while (szam != 3) { 
                szam++;
                Console.WriteLine(szam);
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
            // vagy vagy az és hejet
            /*
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
           *//*WW

            */
            /*
             * 
             * // Az A ne legyen nagyobb mint a B :)
            int a = 12;
            int b = 43;
            for (int i = a + 1; i < b; i++) { 
             Console.WriteLine(i);
            }
            */
            /*
            int a = 49;
            int b = 7;
            if (a > b) {
                for (int i = b + 1; i < a; i++)
                {
                    Console.Write(i + "   ");
                }
            }
            else
            {
             
                for (int i = a + 1; i < b; i++)
                {
                    Console.WriteLine(i);
                }
            }

            */
            /*
            Console.WriteLine("Kérek valamit"); 

            string sex =  Console.ReadLine();

            int szam = int.Parse(sex);
            Console.WriteLine(sex + szam);
            *//*
            Console.WriteLine("Kérek valamit");

            int sex = int.Parse( Console.ReadLine());
            Console.WriteLine(sex);
            */
            /*
            Console.WriteLine("A téglalap á oldala?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("A téglalap b oldala?");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("A téglalap területe" + " " + a * 2 + b * 2);
            */
            List<int> list = new List<int>();
            Console.WriteLine("agyon egy számot");
            list.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Mégegyet");
            list.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Mégegyet");
            list.Add(int.Parse(Console.ReadLine()));
            int c = list.Max();
            Console.WriteLine("Legynagobb elem:" + c);
        }
    }
}
