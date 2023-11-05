using ConsoleInterfaceComparable30oct2023;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welkom bij Rechthoek met IComparable!");

        Rechthoek[] rechthoeken = new Rechthoek[10];
        Rechthoek rechthoek1 = new Rechthoek();
        rechthoek1.Breedte = 10;
        rechthoek1.Lengte = 2;
        rechthoek1.ToonOppervlakte();
        rechthoeken[0] = rechthoek1;

        Rechthoek rechthoek2 = new Rechthoek();
        rechthoek2.Breedte = 1.1;
        rechthoek2.Lengte = 4.5;
        rechthoek2.ToonOppervlakte();
        rechthoeken[1] = rechthoek2;

        Rechthoek rechthoek3 = new Rechthoek();
        rechthoek3.Breedte = 15;
        rechthoek3.Lengte = 1.2;
        rechthoek3.ToonOppervlakte();
        rechthoeken[2] = rechthoek3;

        Rechthoek rechthoek4 = new Rechthoek() { Breedte = 1, Lengte = 1.2 };
        rechthoeken[3] = rechthoek4;
        Rechthoek rechthoek5 = new Rechthoek() { Breedte = 1.4, Lengte = 1.3 };
        rechthoeken[4] = rechthoek5;

        rechthoeken[5] = new Rechthoek() { Breedte = 3.2, Lengte = 2.1 };
        rechthoeken[6] = new Rechthoek() { Breedte = 1.4, Lengte = 1.1 };

        Console.WriteLine("Alle rechthoeken: ");

        foreach (Rechthoek r in rechthoeken)
        {
            r?.ToonOppervlakte();
        }

        Console.WriteLine("Sorteren!");
        Array.Sort(rechthoeken);

        foreach (Rechthoek r in rechthoeken)
        {
            r?.ToonOppervlakte();
        }

        Console.ReadLine();
    }
}