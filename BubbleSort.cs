using System;
using System.Collections.Generic;
using System.Text;

namespace bio2
{
    public class BubbleSort
    {
        public int[] a = new int[10] { 10, 2, 4, 6, 7, 5, 6, 1, 2, 10 };
        public void Main()
        {
            var n = a.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (a[j] > a[j + 1])
                    {
                        var tempVar = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tempVar;
                    }
            Utility.print(a);
        }

    }
}
