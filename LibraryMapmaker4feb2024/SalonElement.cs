using System.Drawing;

namespace LibraryMapmaker4feb2024
{
    public class SalonElement : MapObject, IComposite
    {
        private List<MapObject> elementen = new List<MapObject>();

        public SalonElement(Point salonLoc)
        {
            Location = salonLoc;

            elementen.Add(new ZetelElement(new Point(2 + this.Location.X, 2 + this.Location.Y), 4, '%'));
            elementen.Add(new ZetelElement(new Point(5 + this.Location.X, 9 + this.Location.Y), 3, '^'));
        }

        public override void Paint()
        {
            for (int i = 0; i < elementen.Count; i++)
            {
                elementen[i].Paint();
            }
        }

        public override void Paint(Graphics graphics)
        {
            for (int i = 0; i < elementen.Count; i++)
            {
                elementen[i].Paint(graphics);
            }
        }

        public void UpdateElements(Point offset)
        {
            for (int i = 0; i < elementen.Count; i++)
            {
                Point elementLoc = elementen[i].Location;
                elementLoc.X += offset.X;
                elementLoc.Y += offset.Y;
                elementen[i].Location = elementLoc;
            }
        }
    }
}
