using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class CommonItems
    {
        public bool IsContainingCommonItem(int[] arr1, int[] arr2)
        {
            bool result = false;
            Dictionary<int, bool> map = new();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!map.ContainsKey(arr1[i]))
                {
                    map[arr1[i]] = true;
                }
            }
            for (int j=0; j<arr2.Length;j++)
            {
                if (map.ContainsKey(arr2[j]))
                {
                    result = true;
                   // return result;
                }
            }
            return result;

        }
    }
}
