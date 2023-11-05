namespace ConsoleRootsBessel5nov2023
{
    internal class RootsFinder5nov2023
    {
        public static void BracketRoots(FunctionAbstractClass5nov2023 fx, double x1, double x2, ref List<double> xb1, ref List<double> xb2, out int nroot, int n = 100)
        {
            int nb = 20;
            xb1 = new List<double>(nb);
            xb2 = new List<double>(nb);
            nroot = 0;
            double dx = (x2 - x1) / n;
            double x = x1;
            double fp = fx.Function(x1);

            for (int i = 0; i < n; i++)
            {
                double fc = fx.Function(x += dx);
                if (fc * fp <= 0.0)
                {
                    xb1.Add(x - dx);
                    xb2.Add(x);
                    nroot++;
                    if (nroot == nb)
                    {
                        List<double> tempvec1 = new List<double>(xb1);
                        List<double> tempvec2 = new List<double>(xb2);
                        xb1 = new List<double>(2 * nb);
                        xb2 = new List<double>(2 * nb);
                        for (int j = 0; j < nb; j++)
                        {
                            xb1[j] = tempvec1[j];
                            xb2[j] = tempvec2[j];
                        }
                        nb *= 2;
                    }
                }
                fp = fc;
            }
        }
    }
}
