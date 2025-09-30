class Program
{

    static void Main(string[] args)
    {
        List<string> orszagok = new List <string>();
        
        //listákhoz elem hozzáadás
        orszagok.Add("Magyarország");
        orszagok.Add("Németország");
        orszagok.Add("Franciaország");

        //lista bejárása
        foreach (var item in orszagok)
        {
            Console.WriteLine(item);
        }

        var orszagok2 = new List <string>()
        {
            "Kína", "Japán", "Észak-Korea"
        };
        // benne van-e az elem a listában

        Console.WriteLine(orszagok.Contains("Kina")); //True

        Console.WriteLine(orszagok.Contains("Szingapur"));

        for (int i = 0; i < orszagok2.Count; i++)
        {
            orszagok[i] = orszagok2[i].ToUpper();
        }
        System.Console.WriteLine(string.Join(",", orszagok2));


        // beszúrás

        orszagok2.Insert(0, "Dél-Korea");
        orszagok2.Insert(1, "Kazaksztán");

        orszagok2.Sort();

        Console.WriteLine(string.Join(",", orszagok2));

        //Csökenő sorrend
        orszagok2.Sort((x, y) =>y.CompareTo(x));
        System.Console.WriteLine(string.Join(",", orszagok2));
    }
}