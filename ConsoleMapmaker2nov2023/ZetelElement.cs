namespace ConsoleMapmaker2nov2023
{
    internal class ZetelElement : FurnitureElement
    {
        public ZetelElement()
        {
            Price = 100;
            DrawChar = '+';
            UnitSize = 2;
        }

        public ZetelElement(Point tempLoc, int unitSize = 2, char character = '+', double price = 100.0)
        {
            this.Location.X = tempLoc.X;
            this.Location.Y = tempLoc.Y;
            this.UnitSize = unitSize;
            this.DrawChar = character;
            this.Price = price;
        }
    }
}
