public class KMP{

    public static bool KMPSearch(string text, string pattern)
    {
        int n = text.Length;
        int m = pattern.Length;
        int[] b = ComputeBorder(pattern);
        int i = 0;
        int j = 0;

        while (i < n)
        {
            if (pattern[j] == text[i])
            {
                if (j == m - 1)
                    return true; // match found
                i++;
                j++;
            }
            else if (j > 0)
            {
                j = b[j - 1];
            }
            else
            {
                i++;
            }
        }
        return false; // no match found
    }

    public static int[] ComputeBorder(string pattern)
    {
        int[] b = new int[pattern.Length];
        b[0] = 0;
        int m = pattern.Length;
        int j = 0;
        int i = 1;

        while (i < m)
        {
            if (pattern[j] == pattern[i])
            {
                // j+1 chars match
                b[i] = j + 1;
                i++;
                j++;
            }
            else if (j > 0)
            {
                // j follows matching prefix
                j = b[j - 1];
            }
            else
            {
                // no match
                b[i] = 0;
                i++;
            }
        }
        return b;
    }   

}