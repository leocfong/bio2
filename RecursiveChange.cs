using System;
using System.Collections.Generic;
using System.Text;

namespace bio2
{
    public class RecursiveChange
    {


        private List<int> recursiveChange(int M, List<int> c, ref int bestValue)
        {
            List<int> rc = new List<int>();
            if (M == 0)
            {
                bestValue = 0;
                return rc;
            }
            int bestNumCoins = int.MaxValue;
            int bestci = 0;
            Console.Write(".");
            List<int> best_rc = new List<int>();
            foreach (int ci in c)
            {
                if (M >= ci)
                {
                    List<int> curRc= recursiveChange(M - ci, c, ref bestValue);

                    if (bestValue + 1 < bestNumCoins)
                    {
                        bestNumCoins = bestValue + 1;
                        bestci = ci;
                        best_rc = curRc;
                    }

                }
            }
            rc.Add(bestci);
            rc.AddRange(best_rc);
            bestValue = bestNumCoins;
            return rc;
        }
        public void Main()
        {
            int M = 10;
            List<int> c = new List<int>() { 1, 3, 7 };

            int bestNumCoins=0;
            List<int> ret = recursiveChange(M, c, ref bestNumCoins);
            Console.WriteLine("Result found:" );
            Utility.print(ret);

            Console.WriteLine("Best number of coins: " + bestNumCoins.ToString());

        }
    }
}
