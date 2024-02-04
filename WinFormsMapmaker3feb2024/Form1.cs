namespace WinFormsMapmaker3feb2024
{
    public partial class Form1 : Form
    {
        List<MapObject> allObjects2 = new List<MapObject>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            WallElement steen1 = new WallElement();
            steen1.Paint(e.Graphics);

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
                allObjects1[i].Paint(e.Graphics);
            }

            SalonElement salon1 = new SalonElement(new Point(6, 5));
            salon1.Paint(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Voeg randomzetel toe
            Random r = new Random();
            ZetelElement zetel = new ZetelElement(new Point(r.Next(0, 80), r.Next(0, 18)), r.Next(0, 8));
            allObjects2.Add(zetel);

            PaintObjects();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Beweeg kaart naar beneden
            for (int i = 0; i < allObjects2.Count; i++)
            {
                // list[i].Location.Y++;
                allObjects2[i].Location = new Point(allObjects2[i].Location.X, allObjects2[i].Location.Y + 1);
            }

            PaintObjects();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            SalonElement salon = new SalonElement(new Point(r.Next(0, 80), r.Next(0, 18)));
            allObjects2.Add(salon);

            PaintObjects();
        }

        private void PaintObjects()
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.RoyalBlue);

            // Teken alle objecten
            for (int i = 0; i < allObjects2.Count; i++)
            {
                allObjects2[i].Paint(graphics);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Voeg muur toe
            Random r = new Random();
            Point point = new Point(r.Next(0, 80), r.Next(0, 18));
            WallElement wall = new WallElement(point, '=', 10.0);
            allObjects2.Add(wall);

            PaintObjects();
        }
    }
}
