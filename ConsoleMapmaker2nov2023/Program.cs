namespace ConsoleMapmaker2nov2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {     
            Console.WriteLine("Welcome at Mapmaker!");

            // Dit geeft een sterretje op positie(1,1) op het scherm.
            WallElement steen1 = new WallElement();
            steen1.Paint();

            List<MapObject> allObjects1 = new List<MapObject>(); // lang leve polymorfisme

            // Muurtje
            for (int i = 0; i < 10; i++)
            {
                Point tempLoc = new Point(2 + i, 3);
                WallElement tempWall = new WallElement(tempLoc, '=', 10.0);
                allObjects1.Add(tempWall);
            }

            // Zetel
            allObjects1.Add(new ZetelElement(new Point(6, 8), 3));

            // Teken alle objecten
            for (int i = 0; i < allObjects1.Count; i++)
            {
                allObjects1[i].Paint();
            }

            SalonElement salon1 = new SalonElement(new Point(6, 5));
            salon1.Paint();

            Menu menu1 = new Menu();
            menu1.ShowMenu();

            List<MapObject> allObjects2 = new List<MapObject>();
            Menu menu2 = new Menu();

            do
            {
                menu2.ShowMenu();
                menu2.GetInput(allObjects2);
                Console.Clear();
                // Teken alle objecten
                for (int i = 0; i < allObjects2.Count; i++)
                {
                    allObjects2[i].Paint();
                }
            } while (true);                        
        }
    }
}