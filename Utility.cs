using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace bio2
{
    internal class Utility
    {
        public static void print(List<int> v)
        {
            int count = v.Count;

            if (count > 0)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    Console.Write(v[i]);
                    Console.Write(",");
                }
                Console.WriteLine(v[count - 1]);
            }

        }
        public static bool IsAInB(List<int> a, List<int> b)
        {
            foreach(int x in a)
            {
                if (b.Contains(x) == false)
                {
                    return false;
                }
            }
            return true;
        }
        public static void RemoveAFromB(List<int> a, List<int> b)
        {
            foreach (int x in a)
            {
                b.Remove(b.First(y => y == x));
            }
        }
    }
}
