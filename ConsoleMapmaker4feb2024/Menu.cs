using LibraryMapmaker4feb2024;

namespace ConsoleMapmaker4feb2024
{
    internal class Menu
    {
        public Menu()
        { }

        public void ShowMenu()
        {
            //Tekenen
            TekenBalk(1);
            TekenOpties(2);
            TekenBalk(5);
        }

        private void TekenBalk(int hoogte)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, hoogte);
                Console.Write('*');
            }
        }

        private void TekenOpties(int hoogte)
        {
            Console.SetCursorPosition(5, hoogte);
            Console.Write("A) Voeg zetel toe op willekeurige locatie");
            Console.SetCursorPosition(5, hoogte + 1);
            Console.Write("B) Beweeg kaart naar beneden");
            Console.SetCursorPosition(5, hoogte + 2);
            Console.Write("C) Voeg salon toe op willekeurige locatie");
            Console.SetCursorPosition(5, hoogte + 3);
            Console.Write("Wat wilt u doen?...");
        }

        public void GetInput(List<MapObject> list)
        {
            string input = Console.ReadLine();

            if (input == "A" || input == "a")
            {
                //Voeg randomzetel toe
                Random r = new Random();
                ZetelElement zetel = new ZetelElement(new Point(r.Next(0, 80), r.Next(0, 18)), r.Next(0, 8));
                list.Add(zetel);
            }

            if (input == "B" || input == "b")
            {
                //Beweeg kaart naar beneden
                for (int i = 0; i < list.Count; i++)
                {
                    // list[i].Location.Y++;
                    list[i].Location = new Point(list[i].Location.X, list[i].Location.Y + 1);
                }
            }

            if (input.ToUpper() == "C")
            {
                Random r = new Random();
                SalonElement salon = new SalonElement(new Point(r.Next(0, 80), r.Next(0, 18)));
                list.Add(salon);
            }

        }
    }
}
