namespace ConsoleRootsBessel5nov2023
{
    internal class BesselFunction5nov2023 : FunctionAbstractClass5nov2023
    {
        BesselCalculator5nov2023 bessjy;

        public BesselFunction5nov2023()
        {
            this.bessjy = new BesselCalculator5nov2023();
        }

        public override double Function(double x)
        {
            return this.bessjy.j0(x);
        }

        public double Derivative(double x)
        {
            return -this.bessjy.j1(x);
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
