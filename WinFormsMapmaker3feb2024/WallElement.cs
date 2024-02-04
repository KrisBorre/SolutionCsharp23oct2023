namespace WinFormsMapmaker3feb2024
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

        public override void Paint(Graphics graphics)
        {
            Color black = Color.FromArgb(255, 0, 0, 0);
            Pen blackPen = new Pen(black);
            graphics.DrawLine(blackPen, this.Location.X * 10, this.Location.Y * 10, (this.Location.X + 1) * 10, this.Location.Y * 10);
        }
    }
}
