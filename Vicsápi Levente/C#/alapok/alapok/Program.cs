using System.Runtime.InteropServices;

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

            //Egyszerű programozási tételek

            //Sorozatszámítás

            /*
            int[] numbers = {2, 4, 1, 6, 5, 3};
            int osszeg = 0;

            
            for (int i = 0; i < numbers.Length; i++) 
            {
                osszeg = osszeg + numbers[i];
            }

            Console.WriteLine(osszeg);
            

            int item = 0;
            while (item < numbers.Length) 
            {
                osszeg = osszeg + numbers[i];
                item++;
            }

            Console.WriteLine(osszeg);
            */

            //Eldöntés

            /*
            int[] numbers = { 2, 4, 1, 6, 5, 3 };

            int i = 0;
            bool paratlan = false;
            while (i < numbers.Length) 
            {
                
                if (numbers[i] % 2 == 1)
                {
                   paratlan = true;
                }

                else
                {
                    paratlan = false;
                }

                i++;
            }

            if (paratlan) 
            {
                Console.WriteLine("Van a tömmben páratlan szám");
            }

            else
            {
                Console.WriteLine("Nincs a tömmben páratlan szám");
            }
            */

            //Megszámlálás
            /*
            int[] numbers = { 2, 4, 1, 6, 5, 3 };

            int db = 0;

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0)
                {
                    db++;
                }
            }

            Console.WriteLine(db);
            */

            //Maximumkiválasztás

            /*
            int[] numbers = { 2, 4, 1, 6, 5, 3 };

            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++) 
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine(max);
            */

            /*
            int[] nums = { 12, 6, 25, 2, 54, 23, 84, 20, 18, 9 };

            int db = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] % 3 == 0)
                {
                    db++;
                }
            }

            Console.WriteLine($"A tömbben {db} hárommal osztható szám van.");

            int item = 0;
            while (item < nums.Length && nums[item] !% 2 == 0) 
            {
                item++;
            }

            Console.WriteLine($"A {item + 1}. helyen van az első páratlan szám");

            int item2 = 0;
            bool van = nums[item] !% 3 == 0 && nums[item] !% 5 == 0;
            while (item2 < nums.Length && nums[item] !% 3 == 0 && nums[item] !% 5 == 0)
            {
                item2++;
            }

            if (van) 
            {
                Console.WriteLine("Van ilyen szám a tömbben");
            }

            else
            {
                Console.WriteLine("Nincs ilyen szám a tömbben");
            }

           

            int min = nums[0];

            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                 
            }

            Console.WriteLine($"A {min} a legkisebb szám a tömbben");
            */

            int[] nums = { 12, 6, 25, 2, 54, 23, 84, 20, 18, 9 };

            Console.WriteLine("Adj meg egy számot! ");
            int szam_bemenet = int.Parse(Console.ReadLine());

            int i = 0;
            bool van_benne = false;
            while (i < nums.Length && !van_benne)
            {
                if (szam_bemenet == nums[i]) 
                {
                    van_benne = true;
                }

                else
                {
                    i++;
                }
               
            }

            if (van_benne) 
            {
                Console.WriteLine($"A szám megtalálható a tömbben a {i + 1}. helyen");
            }

            else 
            {
                Console.WriteLine("A szám nem található meg a tömbben");
            }
        }
    }
}
