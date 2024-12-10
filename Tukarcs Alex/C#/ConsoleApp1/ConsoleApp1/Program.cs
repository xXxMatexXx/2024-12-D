// Sorozatszámítás

using System.Globalization;

int[] number = { 2, 4, 1, 6, 5, 3 };

int osszeg = 0;

for (int i = 0; i < number.Length; i++)
{
    osszeg += number[i];
}

Console.WriteLine("Sorozatszámítás: " + osszeg);

// Sorozatszámítás while ciklussal

int j = 0;
osszeg = 0;
while (j < number.Length)
{
    osszeg += number[j];
    j++;
}
Console.WriteLine("While ciklussal: " + osszeg);



