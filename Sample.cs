using System;
using System.Collections.Generic;
using System.Text;

namespace bio2
{
    public class Sample
    {
        public string[] dna = new string[4] {"tttgggaggtctgc",
                                      "gtttaaacacggtc",
                                      "aaaatatataggtc",
                                      "ggtcgggtaacctt"};
        public string motif = "ggtc";
        public int t ;
        public int l = 4;
        public int n ;
        public int[] s = new int[4];
        public char[,] dna_array;
        public int[,] dna_int;
        public void Ini()
        {
            dna_int = Utility.GenerateDnaIntArray(dna);
            t = dna.Length;
            n = dna[0].Length;
        }

    }
}
