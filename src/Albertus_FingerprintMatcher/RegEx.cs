using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Albertus_FingerprintMatcher
{
    internal class RegEx {
        public static Dictionary<char, string> wordPossibleMap = new Dictionary<char, string>{
            { 'a', "[aA4]?" },
            { 'b', "[bB]" },
            { 'c', "[cC]" },
            { 'd', "[dD]" },
            { 'e', "[eE3]?" },
            { 'f', "[fF]" },
            { 'g', "[gG6]" },
            { 'h', "[hH]" },
            { 'i', "[iI1]?" },
            { 'j', "[jJ]" },
            { 'k', "[kK]" },
            { 'l', "[lL]" },
            { 'm', "[mM]" },
            { 'n', "[nN]" },
            { 'o', "[oO0]?" },
            { 'p', "[pP]" },
            { 'q', "[qQ]" },
            { 'r', "[rR]" },
            { 's', "[sS5]" },
            { 't', "[tT]" },
            { 'u', "[uU]?" },
            { 'v', "[vV]" },
            { 'w', "[wW]" },
            { 'x', "[xX]" },
            { 'y', "[yY]" },
            { 'z', "[zZ2]" }
        };

        public static string generateRegEx(string input){
            string regex = "";
            
            foreach (char c in input.ToLower()){
                if (wordPossibleMap.ContainsKey(c)){
                    regex += wordPossibleMap[c];
                } else {
                    regex += c;
                }
            }

            regex = "^" + regex + "$";

            return regex;
        }

        public static bool isMatch(string input, string regEx){
            return Regex.IsMatch(input, regEx);
        }
    }
}
