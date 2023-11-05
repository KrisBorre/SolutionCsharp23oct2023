namespace ConsoleMapmaker2nov2023
{
    internal class WallElement : MapObject
    {
        /// <summary>
        /// als je een default constructor hebt gemaakt die automatisch ieder object op locatie (1,1) zet
        /// </summary>
        public WallElement()
        {
            this.Location.X = 1;
            this.Location.Y = 1;
        }

        public WallElement(Point tempLoc, char character = '=', double price = 10.0)
        {
            this.Location.X = tempLoc.X;
            this.Location.Y = tempLoc.Y;
            this.Price = price;
            this.DrawChar = character;
        }

        public override void Paint()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
        }
    }
}
