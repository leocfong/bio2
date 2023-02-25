using System;
using System.Collections.Generic;
using System.Text;

namespace bio2
{
    public class MergeSort
    {
        public List<int> Merge(List<int> a, List<int> b)
        {
            int n1 = a.Count;
            int n2 = b.Count;
            List<int> c = new List<int>();
            a.Add(int.MaxValue);
            b.Add(int.MaxValue);
            int count = n1 + n2;
            int i = 0; int j = 0;
            for (int k=0;k<count; k++)
            {
                if (i == n1)
                {
                    c.Add(b[j]);
                    j++;
                }
                else if (j == n2)
                {
                    c.Add(a[i]);
                    i++;
                }
                else if(a[i] < b[j])
                {
                    c.Add(a[i]);
                    i++;
                }
                else
                {
                    c.Add(b[j]);
                    j++;
                }
            }
            return c;
        }
        public List<int> mergeSort(List<int> c)
        {
            int n = c.Count;
            if (n == 1)
            {
                return c;
            }
            int midPoint = (int)Math.Floor((decimal)n / 2);
            List<int> left = c.GetRange(0, midPoint);
            List<int> right = c.GetRange(midPoint, midPoint);
            List<int> sortedLeft = mergeSort(left);
            List<int> sortedRight = mergeSort(right);
            List<int> sortedList = Merge(sortedLeft, sortedRight);
            return sortedList;
        }
        public void Main()
        {
            List<int> a = new List<int>() { 1, 3, 5, 7, 9 };
            List<int> b = new List<int>() { 10, 30, 50, 70, 90 };
            List<int> d = new List<int>() { 1, 3, 5, 7, 9, 10, 30, 50, 70, 90 };
            List<int> c = mergeSort(d);
            Utility.print(c);
        }
    }
}
