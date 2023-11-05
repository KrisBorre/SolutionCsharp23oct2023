namespace ConsoleInterfaceComparable31oct2023
{
    internal abstract class GeometricFigure : IComparable
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public int Oppervlakte { get { return BerekenOppervlakte(); } }

        public int CompareTo(object obj)
        {
            GeometricFigure temp = (GeometricFigure)obj;
            if (Oppervlakte > temp.Oppervlakte) return 1;
            if (Oppervlakte < temp.Oppervlakte) return -1;
            return 0;
        }

        protected abstract int BerekenOppervlakte();
    }
}
