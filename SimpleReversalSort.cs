using System;
using System.Collections.Generic;
using System.Text;

namespace bio2
{
    public class SimpleReversalSort
    {
        int[] a = new int[] {6, 1, 2, 3, 4, 5 };
        public void Main()
        {
            int l = a.Length;
            for (int i=0;i<l;i++)
            {
                int j = a[i];
                if (j != i+1)
                {
                    Utility.Swap(a, i, j-1);
                    Utility.print(a);
                }
                if (Utility.IsIdentityPermutation(a))
                {
                    break;
                }
            }
        }
    }
}
