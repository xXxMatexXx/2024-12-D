using System.Diagnostics.CodeAnalysis;

namespace algoritmusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ezek kicsit furán vannak leírva aztán nem értem nagyon de fuck it we ball
            int[] tomb = { 2, 4, 1, 6, 5, 3 };
            /*
            Sorozatszámítás/összegzés Pszeudokód:
            - Bemenet: x - T tömb, n - egész szám(tömb mérete)
            - Kimenet: érték - T 

            - Függvény Sorozatszámitás(x,n)
	            érték <- 0

	            ciklus i <- 1-t n-ig
	                érték <- érték + x [i]
                ciklus vége

	            vissza érték
            függvény vége
            */

            /*
            int ertek = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                ertek = ertek + tomb[i];
            }
            */

            //Console.WriteLine(ertek);

            /*
            Eldöntés:
            - Bemenet: x - T tömb, n - egész szám, P - logikai(tulajdonság)
            - Kimenet: van - logikai

            - Függvény döntés (x,n,P)
                i <- 1

                ciklus amig(i <= n) && P (x[i])
                    i <- i + 1
                ciklus vége 

            van <- (i <= n)
                vissza van
            függvény vége
            */
            //ez a kód rész semenyire se logikus, mert csak az utolsót nézi meg igazából fuh miért lettem beteg geci

            /*
            int eldontesErtek = 0;
            bool paratlan = false;
            while (eldontesErtek < tomb.Length)
            {

                if (tomb[eldontesErtek] % 2 == 1)
                {
                    paratlan = true;
                }

                else
                {
                    paratlan = false;
                }

                eldontesErtek++;
            }

            if (paratlan)
            {
                //Console.WriteLine("Van a tömmben páratlan szám");
            }

            else
            {
                //Console.WriteLine("Nincs a tömmben páratlan szám");
            }
            */

            /*
            - Kiválasztás:
            - Bemenet: x - T tömb, n - egész szám, P-logikai(tulajdonság)
            - Kimenet: index - egész

            - Függvény kiválasztás (x,n,P)
                i <- 1

                ciklus amig(i <= n) && P (x[i])
                    i <- i + 1
                ciklus vége 

                idx <- i
                vissza index
            függvény vége
            */

            /*
            int kivlasztasSzam = 0;
            bool vanEHarom = false;
            while (kivlasztasSzam < tomb.Length && tomb[kivlasztasSzam] != 3)
            {
                kivlasztasSzam++;
            }

            int idx = kivlasztasSzam;
            */

            //Console.WriteLine(idx);

            /*
            - Lineaáris keresés:
            - Bemenet: x - T tömb, n - egész szám, P-logikai
            - Kimenet: index - egész, van - logikai

            - Függvény Lineáris keresés(x,n,P)
                i <- 1
                ciklus amíg(i <= n) A ] P(x[i])
                    i <- i + 1
                ciklus vége

                van <- (1 <= n)
                ha van akkor
                    index <- i
                    vissza(van, index)
                különben 
                    vissza van
                elágazás vége
            függvény vége
            */

            /*
            int keresesSzam = 0;
            bool vanEKetto = false;
            while (keresesSzam < tomb.Length && tomb[keresesSzam] != 2)
            {
                keresesSzam++;
            }

            int idx2 = 0;
            if (keresesSzam != tomb.Length)
            {
                idx2 = keresesSzam;
                vanEKetto = true;
                //Console.WriteLine($"{vanEKetto} {idx2}");
            }
            else
            {
                //Console.WriteLine(vanEKetto);
            }

            */

            /*
            - Megszámlálás
            - Bemenet: x - T tömb, n - egész szám, P - logikai
            - Kimenet: darab - egész

            - Függvény Megszámlálás(x,n,p)
            darab <- 0

            ciklus i <- t-től n-ig
                ha P(x[i]) akkor
                    darab <- darab + 1
                elágazás vége
            ciklus vége

            vissza darab

            függvény vége
            */

            /*
            int darab = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    darab++;
                }
            }
            */

            //Console.WriteLine(darab);

            /*
            - Maximum:
            - Bemenet: x - T tömb, n-egész, P – logikai
            - Kimenet: max – egész

            -függvény Maximum(x, n)
            max <- 1

            ciklus i <- 2-től n-ig
                ha [x] > x[max] akkor
                    max <- i
            elágazás vége

            vissza maximum

            függvény vége
            */

            /*
            int max = 0; //index szerintí vizsgálás
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[max])
                {
                    max = i;
                }
            }

            */

            //Console.WriteLine(tomb[max]);

            /*
            - Minimum:
            - Bemenet: x - T tömb, n-egész, P – logikai
            - Kimenet: min – egész

            -függvény Minimum(x, n)
            min <- 1

            ciklus i <- 2-től n-ig
                ha [x] < x[min] akkor
                    min <- i
            elágazás vége

            vissza minimum

            függvény vége
            */

            /*
            int min = tomb[0]; //értek alpján vizsgáljuk
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }

            //Console.WriteLine(min);
            */

//2024.11.28
            int[] nums = { 12, 6, 25, 2, 54, 23, 84, 20, 18, 9 };
            
            //feladatok
            //3-al osztható számok mennyisége

            /*
            int oszthahó = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 3 == 0)
                {
                    oszthahó++;
                }
            }

            Console.WriteLine($"3-al osztható szmáok száma: {oszthahó}");

            //első páratlan szám helye
            int elsoOsztahto = 0;
            int i28 = 0;


            while (i28 <= nums.Length && nums[i28] % 2 != 1)
            {
                i28++;
            }

            elsoOsztahto = i28;
            Console.WriteLine($"az első páratlan szám helye: {elsoOsztahto + 1}");
            */

            //3-as és 5-al osztható szám

            /*
            bool vanE = false;
            int i282 = 0;

            
            while (i28 < nums.Length && vanE != true)
            {
                if (nums[i28] % 3 == 0 & nums[i28] % 5 == 0)
                {
                    vanE = true;
                }
                i28++;
            }

            Console.WriteLine(vanE);

            //legkisebb szám
            int min2 = nums[0]; //értek alpján vizsgáljuk
            for (int i = 1; i < tomb.Length; i++)
            {
                if (nums[i] < min2)
                {
                    min2 = nums[i];
                }
            }

            Console.WriteLine($"legkisebb szám az a {min2}");
            */

//2024.12.03

            //van e ilyen szám a tomben?
            //és hol van

            /*
            Console.WriteLine("Kérlek adj meg egy számot");
            int megadottSzam = int.Parse(Console.ReadLine());
            i28 = 0;
            vanE = false;
            while (i28 < nums.Length && vanE != true)
            {
                if (nums[i28] == megadottSzam)
                {
                    vanE = true;
                }
                i28++;
            }

            if (vanE)
            {
                Console.WriteLine($"Van benne ez a szám, és a {i28}. helyen van.");
            }
            else 
            {
                Console.WriteLine("Nincs benne ez a szám.");
            }
            */

//2024.12.05
            //páratlan számok összege
            /*
            int osszege = 0;
            int i = 0;
            
            while (i < nums.Length)
            {
                if ((nums[i] % 2 == 1))
                {
                    osszege += nums[i];
                }
                i++;
            }

            Console.WriteLine($"páratlan számok összege: {osszege}");
            */
            int[] numbers = { 321, 221, 24, 123, 5, 330, 512, 12, 73, 88, 21 };
            
            //legkisebb vs legnagyobb a tömben
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if(min > numbers[i]) 
                {
                    min = numbers[i];
                }
            }

            int kulonbseg = max - min;
            Console.WriteLine("a legnagyobb és legkisebb szám különbsége: {0}", kulonbseg);

            //beírt számmal szorozza meg a tömb részeit
            Console.WriteLine("írj be egy stámot");
            int szorzo = int.Parse(Console.ReadLine());
            int j = 0;
            int szorzott = 0;
            Console.WriteLine("Megszorzott tömb: ");
            while (j < numbers.Length)
            {
                Console.Write($"{numbers[j] * szorzo} ");
                j++;
            }
            Console.WriteLine();
            //3 és 10 osztahtói, ha van akkor a nála kisebb számokat írja ki
            bool oszthato = false;
            int inkrement = 0;
            int szam = 0;

            while (inkrement < numbers.Length && !oszthato)
            {
                if (numbers[inkrement] % 10 == 0 && numbers[inkrement] % 3 == 0)
                {
                    oszthato = true;
                    szam = numbers[inkrement];
                }
                inkrement++;
            }

            inkrement = 0;
            Console.WriteLine($" a {szam}-nál kisebb számok: ");

            while (inkrement < numbers.Length)
            {
                if (numbers[inkrement] < szam)
                {
                    Console.Write($"{numbers[inkrement]} ");
                }
                inkrement++;
            }
        }
    }
}