using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class TwoSum
    {
        public static int[] FindSummingNumbers(int[] num, int target)
        {
            var map = new Dictionary<int, int>(); // Simplified collection initialization
            for (int i = 0; i < num.Length; i++)
            {
                int complement = target - num[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { complement, num[i] };
                }
                map[num[i]] = i;
            }
            return Array.Empty<int>(); // Fixed return statement
        }

        public static int[] IndexOfNumberToTarget(int[] num, int target)
        {
            var map = new Dictionary<int, int>(); // Simplified collection initialization
            for (int i = 0; i < num.Length; i++)
            {
                int complement = target - num[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i }; // zero -based index to one-based index
                }
                map[num[i]] = i;
            }
            return Array.Empty<int>(); // Fixed return statement
        }
    }
}
