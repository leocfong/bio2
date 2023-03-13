using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bio2
{
    public class DuplicateRemoval
    {
        public void duplicateremoval(int[] a)
        {
            int m = a.Max(); 
            int n = a.Length;

            int[] b = new int[m+1];
            Array.Fill(b, 0);
            for (int i=0;i<n;i++)
            {
                b[a[i]] = 1;
            }
            for (int i=0;i<m;i++)
            {
                if (b[i] == 1)
                {
                    Console.Write(i.ToString() + ',');
                }
            }

        }
        public void Main()
        {
            int[] a = new int[] { 8, 1, 5, 1, 0, 4, 5, 10, 1 };
            duplicateremoval(a);
        }
    }
}
;