using System;
using System.Collections.Generic;
using System.Text;

namespace bio2
{
    public class SimpleMotifSearch
    {
        public void Main()
        {
            Sample smp = new Sample();
            smp.Ini();
            Utility.print(smp.dna_int);

            int[] zeroes = new int[] { 0, 0, 0, 0 };
            int[] a = new int[] { 0, 0, 0, 0 };
            int[] bestSymbol = (int[])a.Clone();
            int bestScore = 0;
            int i = 0;
            while (true)
            {
                i = Utility.NextVertex(a, i, smp.t-1, smp.n - smp.l);
                //i = Utility.NextVertex(a, i, smp.t - 1, 3);
                if (i< smp.t - 1)
                {
                    int curScore = Utility.Score(smp.dna_int, a, smp.l, i);
                    int o = (smp.t - i - 1) * smp.l;
                    if ((o+curScore) <bestScore)
                    {
                       i = Utility.ByPass(a, i, smp.t - 1, smp.n - smp.l);
                    }
                    else
                    {
                       i = Utility.NextVertex(a, i, smp.t - 1, smp.n - smp.l);
                    }
                }else
                {
                    int curScore = Utility.Score(smp.dna_int, a, smp.l,  i);
                    if (curScore > bestScore)
                    {
                        bestScore = curScore;
                        bestSymbol = (int[])a.Clone();

                        Console.WriteLine("Best symbol is ");
                        Utility.print(bestSymbol);
                        Console.WriteLine("Best score is ");
                        Console.WriteLine(bestScore);
                    }
                    i = Utility.NextVertex(a, i, smp.t - 1, smp.n - smp.l);
                }
                if (i == -1) { break; }
            }
            Console.WriteLine("Best symbol is ");
            Utility.print(bestSymbol);
        }
    }
}
