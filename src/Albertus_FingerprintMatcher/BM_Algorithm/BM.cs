namespace {    
    public class BM {
        public static bool BMMatch (string text, string pattern){
            int n = text.Length;
            int m = pattern.Length;
            int[] bmTable = ComputeTable(pattern);
            int i = m - 1;
            int j = m - 1;

            while (i < n){
                if (pattern[j] == text[i]){
                    if (j == 0){
                        return true;
                    }
                    i--;
                    j--;
                } else {
                    i += m - Math.Min(j, 1 + bmTable[text[i]]);
                    j = m - 1;
                }
            }
            return false;
        }
        public static int[] ComputeTable(string pattern){
            int m = pattern.Length;
            int[] bmTable = new int[256];
            for (int i = 0; i < 256; i++){
                bmTable[i] = m;
            }
            for (int i = 0; i < m - 1; i++){
                bmTable[pattern[i]] = m - 1 - i;
            }
            return bmTable;
        }
    }
}