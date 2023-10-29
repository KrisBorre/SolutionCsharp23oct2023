namespace ConsoleEnum24oct2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Dancer
            {
                Random ran = new Random();

                Dancer.Style style = (Dancer.Style)ran.Next(Enum.GetValues(typeof(Dancer.Style)).Length);
                Console.WriteLine(style);

                Person p1 = new Person("Tom", 4);
                Console.WriteLine(p1.Name);
                p1.Dance();

                Person p2 = new Person("Ellen", 5, 3);
                Console.WriteLine(p2.Name);
                p2.Dance(Dancer.Style.Sala);

                Person p3 = new Person("Seppe", age: 6, 4);
                Console.WriteLine(p3.Name);
                p3.Dance(Dancer.Style.HipHop);

                Person p4 = new Person(name: "Jasmine", age: 7);
                Console.WriteLine(p4.Name);

                Person p5 = new Person(numberOfLegs: 1, age: 3, name: "Jan");
                Console.WriteLine(p5.Name);

                Dancer tom = new Dancer();
                Dancer eva = new Dancer();
                Dancer mike = new Dancer();
                Dancer toon = new Dancer();
                Dancer gwen = new Dancer();

                tom.AantalWedstrijden = 10;
                eva.AantalWedstrijden = 4;
                toon.AantalWedstrijden = 3;
                toon.StelIn("Toon", 5, Schoenen.Tap, gwen, toon.AantalWedstrijden);
                gwen.AantalWedstrijden = 3;
                gwen.Name = "Gwen";
                tom.StelIn("Tom", 12, Schoenen.Latin, eva, tom.AantalWedstrijden);
                eva.Name = "Eva";
                eva.Dansschoenen = Schoenen.Latin;
                mike.StelIn("Mike", 8, Schoenen.Flamenco, tom, 2);
                tom.Toon();
                eva.Toon();
                mike.Toon();
                toon.Toon();
                Dancer.Style style1 = (Dancer.Style)ran.Next(Enum.GetValues(typeof(Dancer.Style)).Length);
                tom.Dance(style1);
                tom.Win();

                Console.WriteLine("Test je methode door 2 objecten aan te maken en telkens mee te geven als parameter.");
                Dancer.SimuleerDanser(eva);
                Dancer.SimuleerDanser(gwen);

                Console.WriteLine("Welkom bij een Wedstrijd.");
                Dancer.SimuleerWedstrijd(tom, toon);

                Dancer winnaar = Dancer.BesteDanser(eva, mike);
                Console.WriteLine($"{winnaar.Name} wint.");
                Dancer.Style style2 = (Dancer.Style)ran.Next(Enum.GetValues(typeof(Dancer.Style)).Length);
                winnaar.Dance(style2);
                winnaar.Toon();
                winnaar.Win();

            }
            #endregion

        }
    }
}