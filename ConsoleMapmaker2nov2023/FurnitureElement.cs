namespace ConsoleMapmaker2nov2023
{
    internal class FurnitureElement : MapObject
    {
        private int unitSize;

        public int UnitSize
        {
            get { return unitSize; }
            set { if (value > 0) { unitSize = value; } }
        }

        public override void Paint()
        {
            for (int i = Location.X; i < Location.X + UnitSize; i++)
            {
                for (int j = Location.Y; j < Location.Y + UnitSize; j++)
                {
                    if (i < Console.WindowWidth && j < Console.WindowHeight)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(DrawChar);
                    }
                }
            }
        }

    }
}
