using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace bio2
{
    public class GreedyMotifSearch
    {
        public void Main()
        {
            Sample smp = new Sample();
            smp.Ini();
            Utility.print(smp.dna_int);
            int[] bestPos = new int[4] { 1, 1, 1, 1 };
            int[] a = new int[] { 0, 0, 0, 0 };
            int i = 1;
            int bestScore = 0;
            int[] bestMotif=(int[])a.Clone();
            while (true)
            {
                //Utility.print(a);
                int curScore = Utility.Score(smp.dna_int, a, smp.l, 1);
                if (curScore > bestScore)
                {
                    bestScore = curScore;
                    bestMotif = (int[])a.Clone();

                }
                i = Utility.NextVertex(a, i, 1, smp.n - smp.l);

                if (i == -1)
                {
                    break;
                }
            }
        
            Console.WriteLine("stage 1");
            Utility.print(bestMotif);
            a = (int[])bestMotif.Clone();
            for (i=2; i<smp.t; i++)
            {
                for (int si = 0;si <= smp.n - smp.l; si++)
                {
                    a[i] = si;
                    int curScore = Utility.Score(smp.dna_int, a,  smp.l, i);
                    if (curScore > bestScore)
                    {
                        bestScore = curScore;
                        bestMotif = (int[])a.Clone();

                    }
                }
            }
            Console.WriteLine("stage 2");
            Utility.print(bestMotif);
        }
    }
}
