using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
   internal class NonRepeatingChar
    {
        //First non-repeating char in given string
        public static char? CharNonRepeating(string s)
        {
            int res = -1;
            if (s.Length < 1) return null;
            Dictionary<char, int> map = new();
            foreach(char c in s)
            {
                map[c]= map.GetValueOrDefault(c, 0) + 1;
            }
            for(int i=0; i<s.Length; i++)
            {
                if (map[s[i]] == 1)
                {
                    res = i;
                    break;
                }
            }
            return s[res];
        }

        /// Indext of first non-repeating char in given string
        /// 
        public static int IndexOfNonRepeatingChar(string s)
        {
            int res = -1;
            if (s.Length < 1) return -1;
            Dictionary<char, int> map = new();
            foreach(char c in s)
            {
                map[c] = map.GetValueOrDefault(c, 0) + 1;
            }
            for(int i=0; i<s.Length;i++)
            {
                if (map[s[i]] == 1)
                {
                    return i;
                }
            }
            return res;
        }
        /// <summary>
        /// Longest Substring Without Repeating Characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public static int LengthOfLongestSubstring(string s)
        {
            if(string.IsNullOrEmpty(s)) return 0;
            HashSet<char> set = new HashSet<char>();
            //int res = set.Count;
            if (s.Length >= 1)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (!set.Add(s[i]))
                    {
                        break;
                        //return set.Count;
                        //res = i + 1;
                    }
                    //return res;

                }
            }
            return set.Count;

        }

        public static string Example(string s)
        {
            if (s.Length < 1) return null;
            string result = null;
            Dictionary<char, int> map = new();
            foreach(char c in s)
            {
                map[c] = map.GetValueOrDefault(c, 0) + 1;

            }
            foreach(KeyValuePair<char, int> pair in map)
            {
                // int value = map[key];
                //result += "{key}{value}";
                result += $"{pair.Key}{pair.Value}";
            }
            return result;
        }
    }
}
