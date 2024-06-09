using System;

namespace Albertus_FingerprintMatcher{
    public class BM
    {
        public static bool BMMatch(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;
            if (m == 0) return false; // No pattern to search
            if (n == 0) return false; // Text is empty

            int[] bmTable = ComputeTable(pattern);
            int i = m - 1;

            while (i < n)
            {
                int k = 0;
                int j = m - 1;
                int shift = bmTable[(int)text[i]];
                while (j >= 0 && pattern[j] == text[i])
                {
                    k++;
                    i--;
                    j--;
                }

                if (j < 0)
                {
                    return true;
                }
                else
                {
                    i += k;
                    i += shift;
                }
            }
            return false;
        }

        public static int[] ComputeTable(string pattern)
        {
            int m = pattern.Length;
            int[] bmTable = new int[256];
            for (int i = 0; i < 256; i++)
            {
                bmTable[i] = m;
            }
            for (int i = 0; i < m - 1; i++)
            {
                bmTable[(int)pattern[i]] = m - 1 - i;

            }
            return bmTable;
        }
    }
}