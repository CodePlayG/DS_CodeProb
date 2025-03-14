using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class NonRepeatingChar
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

    }
}
