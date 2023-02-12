using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bio2
{
    public class AllLeaves
    {
        public void Main()
        {
            List<int> ones = new List<int>() { 1, 1, 1 };
            List<int> a = new List<int>() { 1, 1, 1 };
            while (true)
            {
                Utility.print(a);
                Utility.NextLeaf(a,  4);
                if (Enumerable.SequenceEqual(ones, a))
                {
                    break;
                }
            }
        }
    }
}
