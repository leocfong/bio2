using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace bio2
{
    public class PartialDigest
    {
        int width; List<int> X = new List<int>();
        List<int> L = new List<int> { 2, 2, 3, 3, 4, 5, 6, 7, 8, 10 };
        public void Main()
        {
            width = L.Max();
            L.Remove(L.Single(x => x == width));
            X.Add(0);
            X.Add(width);
            DisplayStatus();
            Place();
            
        }
        public void DisplayStatus()
        {
            Console.Write("L:");
            Utility.print(L);
            Console.Write("X:");
            Utility.print(X);
        }
        public void Place()
        {
            if (L.Count() == 0)
            {
                Console.WriteLine("Solution found");
                Console.WriteLine("****************");
                Utility.print(X);
                Console.WriteLine("****************");
                return;
            }
            int y1 = L.Max();
            List<int> DX1 = (from v in X select Math.Abs(y1 - v)).ToList();
            if (Utility.IsAInB(DX1, L))
            {
                X.Add(y1);
                Utility.RemoveAFromB(DX1, L);
                DisplayStatus();
                Place();
            }
            int y2 = width - y1;
            List<int> DX2 = (from v in X select Math.Abs(y2 - v)).ToList();
            if (Utility.IsAInB(DX2, L))
            {
                X.Add(y2);
                Utility.RemoveAFromB(DX2, L);
                DisplayStatus();
                Place();
            }
        }
    }
}
