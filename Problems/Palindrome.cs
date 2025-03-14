using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programs
{
    class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
           // str = str.Replace("[^A-Za-z0-9]/g", "").ToLower();
            if (str.Length <= 0) return false;
            if (str.Length == 1) return true;
            if(str.Length>1)
            {
                for(int i=0; i<str.Length/2;i++)
                {
                    if (str[i] != str[str.Length-1-i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public static string Reverse(string s)
        {
          // return s.Replace("[^a-zA-Z0-9]", "");
            //string nS = "";
            //string regPat = @"\[A-Za-z0-9]/g";
            return Regex.Replace(s, @"[^A-Za-z0-9]", "").ToLower();
          //  [^a - zA - Z0 - 9]
           // nS = Regex.Replace(s, regPat, 1);
           // return nS;
        }
    }
}
