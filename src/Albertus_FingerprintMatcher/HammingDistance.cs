using System;

namespace Albertus_FingerprintMatcher
{
    public class HammingDistance
    {
        public static double ComputeHammingDistance(string text, string pattern)
        {
            int len = Math.Min(text.Length, pattern.Length);
            int maxLen = Math.Max(text.Length, pattern.Length);

            int distance = 0;
            for (int i = 0; i < len; i++)
            {
                if (text[i] != pattern[i])
                {
                    distance++;
                }
            }

            distance += maxLen - len;

            return 1.0 - (double)distance / maxLen;
        }
    }
}
