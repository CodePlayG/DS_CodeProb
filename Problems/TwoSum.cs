using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class TwoSum
    {
        public static int[] FindSummingNumbers(int[] num, int target)
        {
            Dictionary<int, int> map = new();
            for(int i=0; i<num.Length; i++)
            {
                int complement = target - num[i];
                if(map.ContainsKey(complement))
                {
                    
                    return [map[complement], i]; 
                        //int[]
                }
                map[num[i]] = i;
            }
            return []  ;
        }
    }
}
