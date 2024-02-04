using LibraryMapmaker4feb2024;

namespace WinFormsMapmaker4feb2024
{
    public partial class Form1 : Form
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;

        List<MapObject> allObjects2 = new List<MapObject>();

        public Form1()
        {
            InitializeComponent();

            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 0;
            button1.Text = "Voeg zetel toe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(130, 12);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 1;
            button2.Text = "Beweeg kaart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(246, 12);
            button3.Name = "button3";
            button3.Size = new Size(102, 23);
            button3.TabIndex = 2;
            button3.Text = "Voeg salon toe";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(368, 12);
            button4.Name = "button4";
            button4.Size = new Size(100, 23);
            button4.TabIndex = 3;
            button4.Text = "Voeg muur toe";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Mapmaker";
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            WallElement steen1 = new WallElement();
            steen1.Paint(e.Graphics);

            List<MapObject> allObjects1 = new List<MapObject>(); // lang leve polymorfisme

            // Muurtje
            for (int i = 0; i < 10; i++)
            {
                LibraryMapmaker4feb2024.Point tempLoc = new LibraryMapmaker4feb2024.Point(2 + i, 3);
                WallElement tempWall = new WallElement(tempLoc, '=', 10.0);
                allObjects1.Add(tempWall);
            }

            // Zetel
            allObjects1.Add(new ZetelElement(new LibraryMapmaker4feb2024.Point(6, 8), 3));

            // Teken alle objecten
            for (int i = 0; i < allObjects1.Count; i++)
            {
                allObjects1[i].Paint(e.Graphics);
            }

            SalonElement salon1 = new SalonElement(new LibraryMapmaker4feb2024.Point(6, 5));
            salon1.Paint(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Voeg randomzetel toe
            Random r = new Random();
            ZetelElement zetel = new ZetelElement(new LibraryMapmaker4feb2024.Point(r.Next(0, 80), r.Next(0, 18)), r.Next(0, 8));
            allObjects2.Add(zetel);

            PaintObjects();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Beweeg kaart naar beneden
            for (int i = 0; i < allObjects2.Count; i++)
            {
                // list[i].Location.Y++;
                allObjects2[i].Location = new LibraryMapmaker4feb2024.Point(allObjects2[i].Location.X, allObjects2[i].Location.Y + 1);
            }

            PaintObjects();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            SalonElement salon = new SalonElement(new LibraryMapmaker4feb2024.Point(r.Next(0, 80), r.Next(0, 18)));
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
            LibraryMapmaker4feb2024.Point point = new LibraryMapmaker4feb2024.Point(r.Next(0, 80), r.Next(0, 18));
            WallElement wall = new WallElement(point, '=', 10.0);
            allObjects2.Add(wall);

            PaintObjects();
        }
    }
}
