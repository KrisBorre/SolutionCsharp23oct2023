internal class Program
{
    enum SoortGewicht { ErnstigeZwaarlijvigheid, Zwaarlijvig, Overgewicht, NormaalGewicht, OnderGewicht };

    private static void Main(string[] args)
    {
        Console.WriteLine(Enum.GetValues(typeof(SoortGewicht)).Length); // 5 waarden in enum SoortGewicht.
        Random kiem = new Random();
        Console.WriteLine((SoortGewicht)(kiem.Next(Enum.GetValues(typeof(SoortGewicht)).Length)));
    }
}