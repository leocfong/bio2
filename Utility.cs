using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
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
        public static void print(int[] v)
        {
            int t = v.Count();
   
            for (int i = 0; i < t-1; i++)
            {
                Console.Write(v[i]);
                Console.Write(",");
            }
            Console.WriteLine(v[t - 1]);
        }
        public static void print(int[,] v)
        {
            int t = v.GetLength(0);
            int n = v.GetLength(1);
            for (int i=0;i<t;i++)
            {
                for (int j=0;j<n;j++)
                {
                    Console.Write(v[i,j]);
                }
                Console.WriteLine();
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
        public static void NextLeaf(int[] a, int k)
        {
            int L = a.Length - 1;
            for (int i = L; i >= 0; i--)
            {
                if (a[i] < k)
                {
                    a[i] = a[i] + 1;
                    return;
                }
                a[i] = 0;

            }
        }
        public static void NextLeaf(List<int> a, int k)
        {
            int L = a.Count - 1;
            for (int i = L; i >= 0; i--)
            {
                if (a[i] < k)
                {
                    a[i] = a[i] + 1;
                    return;
                }
                a[i] = 0;

            }
        }
        public static int NextVertex(List<int> a, int i, int L, int k)
        {
            if (i<L)
            {
                a[i + 1] = 1;
                return i + 1;
            }
            else
            {
                for (int j=L; j >= 0; j--)
                {
                    if (a[j] < k)
                    {
                        a[j] = a[j] + 1;
                        return j;
                    }
                }
            }
            return 0;
        }
        public static int NextVertex(int[] a, int i, int L, int k)
        {
            if (i < L)
            {
                a[i + 1] = 0;
                return i + 1;
            }
            else
            {
                for (int j = L; j >= 0; j--)
                {
                    if (a[j] < k)
                    {
                        a[j] = a[j] + 1;
                        return j;
                    }
                }
            }
            return -1;
        }
        public static int ByPass(int[] a, int i, int L, int k)
        {
            for (int j = i; i>=0; j--)
            {
                if (a[j] < k)
                {
                    a[j] = a[j] + 1;
                    return j;
                }
            }
            return 0;
        }
        public static int ByPass(List<int> a, int i, int L, int k)
        {
            for (int j = i; i >= 0; j--)
            {
                if (a[j] < k)
                {
                    a[j] = a[j] + 1;
                    return j;
                }
            }
            return 0;
        }

        public static int[,] GenerateDnaIntArray(string[] dna)
        {
            int len = dna.Length;
            int seq_len = dna[0].Length;
            int[,] dna_int = new int[len, seq_len];
            int i = 0;
            foreach (string s in dna)
            {
                int j = 0;
                char[] a = s.ToCharArray();
                foreach (char c in a)
                {
                    switch (c)
                    {
                        case 'g':
                            dna_int[i, j++] = 0;
                            break;
                        case 'a':
                            dna_int[i, j++] = 1;
                            break;
                        case 't':
                            dna_int[i, j++] = 2;
                            break;
                        case 'c':
                            dna_int[i, j++] = 3;
                            break;
                    }
                }
                i++;
            }
            return dna_int;

        }
        public static int Score(int[,] dna_int, int[] a, int l)
        {
            int t = dna_int.GetLength(0);
            int n = dna_int.GetLength(1);
      
            int[] maxscore = new int[n];
            for (int i=0;i<l;i++)
            {
                int[] sc = new int[4];
                for (int j=0;j<t;j++)
                {
                    int index = dna_int[j, a[j] + i];
                    sc[index]++;
                }
                maxscore[i] = sc.Max();
            }
            int ms = maxscore.Sum();
            return ms;
        }
    }
}
