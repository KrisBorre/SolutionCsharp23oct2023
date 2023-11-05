namespace ConsoleRootsBessel5nov2023
{
    internal class BesselFunction5nov2023 : FunctionAbstractClass5nov2023
    {
        public override double Function(double x)
        {
            var bessjy = new BesselCalculator5nov2023();
            return bessjy.j0(x);
        }
    }


    internal class Sinus5nov2023 : FunctionAbstractClass5nov2023
    {
        public override double Function(double x)
        {
            return Math.Sin(x);
        }

        public override string ToString()
        {
            return "sin(x)";
        }
    }
}
