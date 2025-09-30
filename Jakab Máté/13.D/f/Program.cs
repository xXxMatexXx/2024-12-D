class Person
{
    public string Name;

    public static int Count =0;

    public Person(string name)
    {
        Name = name;
        Count++;
    }


}

    class UnitConverter
    {
        public static double KgToLibs(double weight) => weight*2.20462262185;

        public static double LbsToKG(double weight) => weight*0.4539237;
    }

    class RandomNumber
    {
        private static Random random;

           static RandomNumber()
           {
                random = new Random();
           }

           public int Get() => random.Next();

    }

class Program
{
    static void Main(string[] args)
    {
        var p1 = new Person("Marcell");
        var p2 = new Person("Zsombor");

        System.Console.WriteLine($"p1 name: {p1.Name}");
        System.Console.WriteLine($"p2 name: {p2.Name}");

        double weight = UnitConverter.KgToLibs(100);
        System.Console.WriteLine($"100 kg = {weight} lbs");
        weight = UnitConverter.LbsToKG(100);
        System.Console.WriteLine($"100lbs = {weight: #0.0} kg");

        RandomNumber random= new();

        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine(random.Get());
        }
    }
}