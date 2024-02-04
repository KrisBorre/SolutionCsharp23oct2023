namespace WinFormsMapmaker3feb2024
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

        public override void Paint(Graphics graphics)
        {
            Color red = Color.FromArgb(255, 255, 0, 0);
            Pen redPen = new Pen(red);
            redPen.Width = 3;

            for (int i = Location.X; i < Location.X + UnitSize; i++)
            {
                for (int j = Location.Y; j < Location.Y + UnitSize; j++)
                { 
                    graphics.DrawRectangle(redPen, i * 10, j * 10, (i + 3) * 10, (j + 2) * 10);
                }
            }
        }

    }
}
