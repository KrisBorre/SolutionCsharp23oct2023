namespace ConsoleInterfaceComparable30oct2023
{
    internal class Rechthoek : IComparable
    {
        private double lengte;
        private double breedte;

        public double Lengte
        {
            get { return lengte; }
            set { if (value >= 1) { lengte = value; } }
        }

        public double Breedte
        {
            get { return breedte; }
            set { if (value >= 1) { breedte = value; } }
        }

        public int CompareTo(object obj)
        {
            Rechthoek temp = (Rechthoek)obj;

            if ((this.Lengte * this.Breedte) > (temp.Lengte * temp.Breedte)) return 1;
            if ((this.Lengte * this.Breedte) < (temp.Lengte * temp.Breedte)) return -1;

            return 0;
        }

        public void ToonOppervlakte()
        {
            Console.WriteLine($"De oppervlakte van rechthoek met lengte {Lengte} en breedte {Breedte} is {Lengte * Breedte}");
        }
    }
}
