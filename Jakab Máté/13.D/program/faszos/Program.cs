class Tanulo
{
    public string Vezeteknev { get; set; }
    public string Keresztnev { get; set; }

    public override string ToString()
    {
        return $"A Tanulo neve: {Vezeteknev} {Keresztnev}";
    }
}

class Kurzus
{
    public string Oktato { get; set; }
    public int Oraszam { get; set; }
    public string Osztaly { get; set; }
    public string KurzusNev { get; set; }

    public override string ToString()
    {
        //Több sorban való megjelenitéshez Alt + z
        return $"A kurzus neve: {KurzusNev}, oraszam: {Oraszam}, csoport neve: {Osztaly} és az oktato neve: {Oktato}";
    }
}

//F1 - Format Document
class Program
{
    struct Kordinata
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return $"({this.x}, {this.y})";
        }
        //Kiírásnál jelenjen meg íg (x, y)
        System.Console.WriteLine(this,x);


        public Kordinata(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    static void Main(string[] args)
    {
        Kordinata pont = new Kordinata();
        System.Console.WriteLine(pont);
        pont.x = 10;
        pont.y = 20;
        System.Console.WriteLine(pont);

        /*
        Tanulo s1 = new Tanulo();
        s1.Vezeteknev = "Joe";
        s1.Keresztnev = "Doe";

        System.Console.WriteLine(s1);
        Tanulo s2 = new Tanulo();
        s2.Vezeteknev = "Jakab";
        s2.Keresztnev = "Máté";

        System.Console.WriteLine(s2);

        Kurzus k1 = new Kurzus(); // explicit definiálás
        k1.KurzusNev = "AMAF";
        k1.Oraszam = 8;
        k1.Osztaly = "13 D";
        k1.Oktato = "Bákonyi Sándor";

        var k2 = new Kurzus(); //implicit definiálás
        System.Console.WriteLine(k2.GetType());

        //int, str, dbl,bool,
        var i = 10;
        System.Console.WriteLine(i.GetType());

        var str = "alma";
        System.Console.WriteLine(str.GetType());

        var f = 2.5;
        System.Console.WriteLine(f.GetType());

         var c = 'o';
         System.Console.WriteLine(c.GetType());
         
        //sztingek, mint karatertömb
        char[] chars = { 'a', 'l', 'm', 'a' };
        String a = new String(chars);
        string b = new string(chars);

        System.Console.WriteLine(a.GetType());
        System.Console.WriteLine(b.GetType());

        foreach (var c in a)
        {
            System.Console.WriteLine(c);
        }
        */
    }
}
