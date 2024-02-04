using System.Drawing;

namespace LibraryMapmaker4feb2024
{
    public abstract class MapObject
    {
        private Point location;

        public Point Location
        {
            get { return location; }
            set
            {
                Point prevloc = location;
                Point offset = new Point(1, 1);
                if (location != null)
                {

                    offset.X = value.X - prevloc.X;
                    offset.Y = value.Y - prevloc.Y;
                }

                location = value;
                if (this is IComposite)
                {
                    IComposite obj = this as IComposite;
                    obj.UpdateElements(offset);
                }
            }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private char drawChar;

        /// <summary>
        /// DrawChar geeft aan met welk karakter het item moet getoond worden.
        /// </summary>
        public char DrawChar
        {
            get { return drawChar; }
            set { drawChar = value; }
        }

        public MapObject()
        {
            Location = new Point(1, 1);
            DrawChar = '*';
            Price = 1.0;
        }

        public MapObject(Point location, char character = '*', double price = 1.0)
        {
            Location = location;
            DrawChar = character;
            Price = price;
        }

        /// <summary>
        /// Teken object in de console
        /// </summary>
        public abstract void Paint();

        /// <summary>
        /// Teken object in Windows Form
        /// </summary>
        /// <param name="graphics"></param>
        public abstract void Paint(Graphics graphics);
    }
}
