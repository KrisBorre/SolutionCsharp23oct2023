namespace ConsoleEnum24oct2023
{
    internal enum Schoenen { Latin, Ballet, Flamenco, Tap, HipHop };

    internal class Dancer : Person
    {
        public enum Style { Sala, Mambo, Rumba, Jive, Swing, Ballet, Flamenco, Jazz, Tap, HipHop, Urban };

        private Schoenen dansschoenen;

        public Schoenen Dansschoenen
        {
            get { return dansschoenen; }
            set { dansschoenen = value; }
        }

        private Dancer danspartner;

        public Dancer Danspartner
        {
            get { return danspartner; }
            set { danspartner = value; }
        }

        private int aantalWedstrijden;

        public int AantalWedstrijden
        {
            get
            {
                return aantalWedstrijden;
            }
            set
            {
                if (value > 0)
                {
                    aantalWedstrijden = value;
                }
            }
        }

        public Dancer() : base(name: "", age: 0)
        {
        }

        public override void Dance(Style style)
        {
            for (int i = 0; i < Legs.Length; i++)
            {
                if (Legs[i].HasKnees && Legs[i].Muscle != Muscularity.Fat && Legs[i].LeftOfRight == Leg.LeftOrRight.Right)
                {
                    Console.WriteLine($"{Name} danst {style}.");
                }
            }
        }

        public void Win()
        {
            Console.WriteLine($"{Name} heeft weer een danswedstrijd gewonnen ....");
        }

        public void StelIn(string naam, int leeftijd, Schoenen dansschoenen, Dancer danspartner, int aantalWedstrijden)
        {
            this.Name = naam;
            this.Age = leeftijd;
            this.Dansschoenen = dansschoenen;
            this.Danspartner = danspartner;
            this.AantalWedstrijden = aantalWedstrijden;
        }

        public void Toon()
        {
            if (this.Danspartner != null) Console.WriteLine($"Danser {this.Name} danst met {this.Danspartner.Name}.");
            Console.WriteLine($"Danser {this.Name} heeft {this.AantalWedstrijden} keer gedanst.");
            Console.WriteLine($"Danser {this.Name} heeft {this.Dansschoenen} dansschoenen.");
        }

        public static void SimuleerDanser(Dancer danser)
        {
            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                Style style = (Style)ran.Next(Enum.GetValues(typeof(Style)).Length);
                danser.Dance(style);
            }
            for (int i = 0; i < 3; i++)
            {
                danser.Win();
            }
        }

        /// <summary>
        /// Bij aanroep van de methode verschijnt er op het scherm wie van beide speler zou winnen als ze zouden spelen. 
        /// Gebruik een random uitkomst om te bepalen over speler 1 of 2 wint. Toon op het scherm "Speler 1 wint." 
        /// Gevolg door de aanroep van iedere methode van die speler.
        /// </summary>
        /// <param name="danser1"></param>
        /// <param name="danser2"></param>
        public static void SimuleerWedstrijd(Dancer danser1, Dancer danser2)
        {
            Random ran = new Random();
            Dancer winnaar;
            int iWinnaar = ran.Next(1, 3); // 1 of 2
            if (iWinnaar == 1) winnaar = danser1;
            else winnaar = danser2;
            Console.WriteLine($"{winnaar.Name} wint.");
            Style style = (Style)ran.Next(Enum.GetValues(typeof(Style)).Length);
            winnaar.Dance(style);
            winnaar.Toon();
            winnaar.Win();
        }

        /// <summary>
        /// Deze methode gaat ook random bepalen welke speler de beste is. Vervolgens geef je deze speler terug als resultaat. In de main roep je vervolgens iedere methode van dit object aan.
        /// </summary>
        /// <param name="danser1"></param>
        /// <param name="danser2"></param>
        /// <returns></returns>
        public static Dancer BesteDanser(Dancer danser1, Dancer danser2)
        {
            Random ran = new Random();
            Dancer winnaar;

            int iWinnaar = ran.Next(1, 3); // 1 of 2
            if (iWinnaar == 1) winnaar = danser1;
            else winnaar = danser2;

            return winnaar;
        }

        /// <summary>
        /// https://en.wikipedia.org/wiki/Jazz_hands
        /// </summary>
        public void JazzHands()
        {
            if (this.GetLeftHand().IsHoldingWeapon || this.GetRightHand().IsHoldingWeapon)
            {
                this.Dance(Style.Jazz);
                this.Win();
            }
        }
    }
}
