namespace ConsoleMapmaker2nov2023
{
    internal class Point
    {
        int x;
        int y;

        public Point(int inx, int iny)
        {
            x = inx;
            y = iny;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
