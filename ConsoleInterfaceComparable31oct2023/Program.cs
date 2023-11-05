using ConsoleInterfaceComparable31oct2023;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welkom bij een abstracte klasse GeometricFigure met de interface IComparable!");

        #region IComparable
        {
            Rechthoek[] rechthoeken = new Rechthoek[10];
            Rechthoek rechthoek1 = new Rechthoek();
            rechthoek1.Breedte = 10;
            rechthoek1.Hoogte = 2;
            ToonOppervlakte(rechthoek1);
            rechthoeken[0] = rechthoek1;

            Rechthoek rechthoek2 = new Rechthoek();
            rechthoek2.Breedte = 11;
            rechthoek2.Hoogte = 45;
            ToonOppervlakte(rechthoek2);
            rechthoeken[1] = rechthoek2;

            Rechthoek rechthoek3 = new Rechthoek();
            rechthoek3.Breedte = 15;
            rechthoek3.Hoogte = 12;

            rechthoeken[2] = rechthoek3;

            Rechthoek rechthoek4 = new Rechthoek() { Breedte = 1, Hoogte = 12 };
            rechthoeken[3] = rechthoek4;
            Rechthoek rechthoek5 = new Rechthoek() { Breedte = 14, Hoogte = 13 };
            rechthoeken[4] = rechthoek5;

            rechthoeken[5] = new Rechthoek() { Breedte = 32, Hoogte = 21 };
            rechthoeken[6] = new Rechthoek() { Breedte = 14, Hoogte = 11 };

            Console.WriteLine("Alle rechthoeken: ");

            foreach (Rechthoek r in rechthoeken)
            {
                ToonOppervlakte(r);
            }

            Console.WriteLine("Sorteren!");
            Array.Sort(rechthoeken);

            foreach (Rechthoek r in rechthoeken)
            {
                ToonOppervlakte(r);
            }

        }
        #endregion

        //Console.ReadLine();

        #region Geometrische Figuren
        {
            Console.WriteLine("Welkom bij Geometrische Figuren!");

            {
                Vierkant vierkant = new Vierkant(4);
                Console.WriteLine("Een vierkant met zijde 4 heeft oppervlakte: " + vierkant.Oppervlakte);
            }
            {
                GeometricFigure vierkant2 = new Vierkant(2, 3);
                Console.WriteLine("Een vierkant met zijde 2 heeft oppervlakte: " + vierkant2.Oppervlakte);
            }
            {
                Rechthoek vierkant3 = new Vierkant(6);
                Console.WriteLine("Een vierkant met zijde 6 heeft oppervlakte: " + vierkant3.Oppervlakte);
            }
            {
                Rechthoek rechthoek1 = new Rechthoek();
                rechthoek1.Breedte = 4;
                rechthoek1.Hoogte = 5;
                Console.WriteLine("Een rechthoek van 4 bij 5 heeft oppervlakte: " + rechthoek1.Oppervlakte);
            }
            {
                GeometricFigure rechthoek2 = new Rechthoek();
                rechthoek2.Breedte = 6;
                rechthoek2.Hoogte = 5;
                Console.WriteLine("Een rechthoek van 6 bij 5 heeft oppervlakte: " + rechthoek2.Oppervlakte);
            }
            {
                Driehoek driehoek1 = new Driehoek();
                driehoek1.Breedte = 3;
                driehoek1.Hoogte = 2;
                Console.WriteLine($"Een driehoek met breedte {driehoek1.Breedte} en hoogte {driehoek1.Hoogte} heeft oppervlakte: " + driehoek1.Oppervlakte);
            }
            {
                GeometricFigure driehoek2 = new Driehoek();
                driehoek2.Breedte = 1;
                driehoek2.Hoogte = 2;
                Console.WriteLine($"Een driehoek met breedte {driehoek2.Breedte} en hoogte {driehoek2.Hoogte} heeft oppervlakte: " + driehoek2.Oppervlakte);
            }
        }
        #endregion

        Console.ReadLine();
    }

    static void ToonOppervlakte(Rechthoek r)
    {
        if (r != null) Console.WriteLine($"De rechthoek met breedte {r.Breedte} en hoogte {r.Hoogte} heeft oppervlakte {r.Oppervlakte}.");
    }
}