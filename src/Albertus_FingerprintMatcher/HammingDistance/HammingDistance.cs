namespace Albertus_FingerprintMatcher{
    public class HammingDistanceCalculator
    {
        public static int ComputeHammingDistance(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                throw new ArgumentException("Strings must be of the same length");
            }

            int distance = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    distance++;
                }
            }

            return distance;
        }
    }
}