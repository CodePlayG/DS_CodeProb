using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class CommonItems
    {
        public static bool OneEdit(string stringOne, string stringTwo)
        {
            int s1 = stringOne.Length, s2 = stringTwo.Length;
            int dif = 0;
            bool isOneEdit = false;
            if (Math.Abs(s1 - s2) > 1) return false;

            for (int i = 0; i < Math.Min(s1, s2); i++)
            {
                if (stringOne[i] != stringTwo[i])
                {
                    dif++;
                    if (s1 == s2 && dif > 1) return false;
                    if (s1 > s2 && stringOne[i + 1] != stringTwo[i] || dif > 1) return false;
                    if (s1 < s2 && stringOne[i] != stringTwo[i + 1] || dif > 1) return false;
                }
                isOneEdit = true;
            }
            return isOneEdit;
        }


        /// <summary>
        /// Given an integer array nums, return true if any value appears more than once in the array,
        /// otherwise return false.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>boolean: true/false</returns>
        /// Space Complexity: O(n) where n is the number of elements in the array.
        /// time Complexity: O(n) where n is the number of elements in the array.
        /// with sorting complexit nlog(n) while space: O(1)

        public static bool ContainsDuplicate(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                //set.Contains(arr[i]);
                if (!set.Add(arr[i]))
                {
                    return true; // Duplicate found
                }
            }
            return false; // No duplicates found
        }



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
