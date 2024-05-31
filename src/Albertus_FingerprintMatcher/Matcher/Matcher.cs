using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albertus_FingerprintMatcher{
    public class Matcher{
        Database_Searching database = new Database_Searching();

        public List<String> FindMatch(String input, String algoritma){
            bool find = false;
            List<String> result = new List<String>();
            List<String> path = database.GetPath();
            List<String> name = database.GetName();
            int idx = 0;
            String pattern = imgMethod.imgToASCII_30Pxl(input);
            if (algoritma.Equals("KMP"))
            {
                for (int i=0; i<path.Count; i++)
                {
                    String text = imgMethod.imgToASCII(path[i]);
                    find = KMP.KMPSearch(text,pattern);
                    if (find)
                    {
                        result.Add(path[i]);
                        result.Add(name[i]);
                        result.Add("100%");
                        break;
                    }
                }
            } else
                for (int i = 0; i < path.Count; i++)
                {
                    String text = imgMethod.imgToASCII(path[i]);
                    find = BM.BMMatch(text, pattern);
                    if (find)
                    {
                        result.Add(path[i]);
                        result.Add(name[i]);
                        result.Add("100%");
                        break;
                    }
                }
            if (!find)
            {
                double percentage = 0;
                for (int i = 0; i < path.Count; i++)
                {   
                    String fullPattern= imgMethod.imgToASCII(input);
                    String text = imgMethod.imgToASCII(path[i]);
                    double current = HammingDistance.ComputeHammingDistance(text, fullPattern);
                    if (current>percentage)
                    {   
                        percentage = current;
                        result.Add(path[i]);
                        result.Add(name[i]);
                        result.Add(percentage.ToString()+"%");
                    }
                }
            }
            return result;
        }
        
    }
}

