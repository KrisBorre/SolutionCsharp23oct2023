namespace ConsoleRootsBessel5nov2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("We zoeken de wortels van de Bessel functie.");
            Console.WriteLine("We search the roots of the Bessel function.");

            int N = 100, NBMAX = 20;
            const double X1 = 1.0, X2 = 50.0;
            int i, nb = NBMAX;
            List<double> xb1 = new List<double>(NBMAX);
            List<double> xb2 = new List<double>(NBMAX);

            RootsFinder5nov2023.BracketRoots(new BesselFunction5nov2023(), X1, X2, ref xb1, ref xb2, out nb, N);
            Console.WriteLine();
            Console.WriteLine("brackets for roots of bessj0:");

            Console.WriteLine("             lower       upper      f(lower)    f(upper)");

            BesselFunction5nov2023 b = new BesselFunction5nov2023();
            for (i = 0; i < nb; i++)
            {
                Console.Write("root ");
                Console.Write("{0,3}", i + 1);
                Console.Write("{0,12:F6}", xb1[i]);
                Console.Write("{0,12:F6}", xb2[i]);
                Console.Write("{0,12:F6}", b.Function(xb1[i]));
                Console.Write("{0,12:F6}", b.Function(xb2[i]));
                Console.WriteLine();
            }
            /*
brackets for roots of bessj0:
            lower      upper        f(lower)   f(upper)
root  1     1.9800     2.4700        0.2354    -0.0334
root  2     5.4100     5.9000       -0.0378     0.1220
root  3     8.3500     8.8400        0.0826    -0.0497
root  4    11.7800    12.2700       -0.0027     0.1049
root  5    14.7200    15.2100        0.0436    -0.0564
root  6    17.6600    18.1500       -0.0759     0.0148
root  7    21.0900    21.5800        0.0211    -0.0619
root  8    24.0300    24.5200       -0.0516     0.0269
root  9    27.4600    27.9500        0.0051    -0.0665
root 10    30.4000    30.8900       -0.0336     0.0363
root 11    33.3400    33.8300        0.0583    -0.0074
root 12    36.7700    37.2600       -0.0193     0.0440
root 13    39.7100    40.2000        0.0432    -0.0178
root 14    43.1400    43.6300       -0.0073     0.0504
root 15    46.0800    46.5700        0.0304    -0.0265
root 16    49.0200    49.5100       -0.0509     0.0031
*/

            /*

brackets for roots of bessj0:
             lower       upper      f(lower)    f(upper)
root   1    1,980000    2,470000    0,235438   -0,033361
root   2    5,410000    5,900000   -0,037758    0,122033
root   3    8,350000    8,840000    0,082645   -0,049739
root   4   11,780000   12,270000   -0,002683    0,104914
root   5   14,720000   15,210000    0,043550   -0,056373
root   6   17,660000   18,150000   -0,075880    0,014771
root   7   21,090000   21,580000    0,021084   -0,061856
root   8   24,030000   24,520000   -0,051587    0,026871
root   9   27,460000   27,950000    0,005097   -0,066535
root  10   30,400000   30,890000   -0,033642    0,036269
root  11   33,340000   33,830000    0,058338   -0,007429
root  12   36,770000   37,260000   -0,019286    0,043950
root  13   39,710000   40,200000    0,043231   -0,017757
root  14   43,140000   43,630000   -0,007259    0,050380
root  15   46,080000   46,570000    0,030353   -0,026520
root  16   49,020000   49,510000   -0,050860    0,003106*/


            N = 10000;
            Console.WriteLine($"N =  {N}");

            RootsFinder5nov2023.BracketRoots(new BesselFunction5nov2023(), X1, X2, ref xb1, ref xb2, out nb, N);
            Console.WriteLine();
            Console.WriteLine("brackets for roots of bessj0:");
            Console.WriteLine("             lower       upper      f(lower)    f(upper)");

            for (i = 0; i < nb; i++)
            {
                Console.Write("root ");
                Console.Write("{0,3}", i + 1);
                Console.Write("{0,12:F6}", xb1[i]);
                Console.Write("{0,12:F6}", xb2[i]);
                Console.Write("{0,12:F6}", b.Function(xb1[i]));
                Console.Write("{0,12:F6}", b.Function(xb2[i]));
                Console.WriteLine();
            }
            /*N =  10000

brackets for roots of bessj0:
             lower       upper      f(lower)    f(upper)
root   1    2,401400    2,406300    0,001780   -0,000765
root   2    5,517800    5,522700   -0,000775    0,000892
root   3    8,648900    8,653800    0,001311   -0,000020
root   4   11,789800   11,794700   -0,000403    0,000736
root   5   14,930700   14,935600    0,000045   -0,000967
root   6   18,066700   18,071600   -0,000819    0,000101
root   7   21,207600   21,212500    0,000699   -0,000150
root   8   24,348500   24,353400   -0,000642    0,000150
root   9   27,489400   27,494300    0,000621   -0,000125
root  10   30,630300   30,635200   -0,000621    0,000086
root  11   33,771200   33,776100    0,000634   -0,000038
root  12   36,917000   36,921900   -0,000013    0,000631
root  13   40,057900   40,062800    0,000066   -0,000551
root  14   43,198800   43,203700   -0,000120    0,000474
root  15   46,339700   46,344600    0,000174   -0,000400
root  16   49,480600   49,485500   -0,000228    0,000328*/


            Console.Read();
        }
    }
}