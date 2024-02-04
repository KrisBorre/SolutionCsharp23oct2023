using System.Drawing;

namespace LibraryMapmaker4feb2024
{
    public class FurnitureElement : MapObject
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
            Random r = new Random();
            Color color = Color.FromArgb(255, r.Next(0, 255), r.Next(0, 80), r.Next(0, 80));
            Pen colorPen = new Pen(color);
            colorPen.Width = r.Next(3, 8);

            for (int i = Location.X; i < Location.X + UnitSize; i++)
            {
                for (int j = Location.Y; j < Location.Y + UnitSize; j++)
                {
                    graphics.DrawRectangle(colorPen, i * 10, j * 10, (i + 3) * 10, (j + 2) * 10);
                }
            }
        }

    }
}
