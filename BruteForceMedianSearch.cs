using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bio2
{
    public class BruteForceMedianSearch
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
            while (true)
            {
               // Utility.print(a);
                //Utility.NextLeaf(a, 6);
                Utility.NextLeaf(a, smp.n-smp.l);
                int curScore = Utility.Score(smp.dna_int, a, smp.l);
                if (curScore > bestScore)
                {
                    bestScore = curScore;
                    bestSymbol = (int[])a.Clone();

                    Console.WriteLine("Best symbol is ");
                    Utility.print(bestSymbol);
                    Console.WriteLine("Best score is ");
                    Console.WriteLine(bestScore);
                }
                if (Enumerable.SequenceEqual(zeroes, a))
                {
                    break;
                }
            }
            Console.WriteLine("Best symbol is");
            Utility.print(bestSymbol);
        }
    }
}
