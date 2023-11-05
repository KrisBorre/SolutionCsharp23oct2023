namespace ConsoleInterfaceComparable31oct2023
{
    internal class Driehoek : GeometricFigure
    {
        protected override int BerekenOppervlakte()
        {
            return (int)((Hoogte * Breedte) / 2.0);
        }
    }
}
