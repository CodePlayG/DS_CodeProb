using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class ValidateSequence
    {

        public static bool IsValidSequence(List<int> array, List<int> sequence)
        {
            //int counter = 0;
            //int flag = 0;
            //for (int i = 0; i < sequence.Count; i++)
            //{
            //    for (int j = counter; j < array.Count; j++)
            //    {
            //        if (array[j] == sequence[i])
            //        {
            //            flag++;
            //            if (j < sequence.Count) counter++;
            //            break;
            //        }
            //        if (flag == sequence.Count) return true;
            //    }

            //}

            //return false;

            int arrPtr = 0;
            int seqPtr = 0;

            while (arrPtr < array.Count && seqPtr < sequence.Count)
            {
                if (array[arrPtr] == sequence[seqPtr]) seqPtr++;
                arrPtr++;
            }
            return seqPtr == sequence.Count;
        }

        public static bool IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            // Array.Sort(s1.ToCharArray());
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                map[s1[i]] = map.GetValueOrDefault(s1[i], 0) + 1;
                map[s2[i]] = map.GetValueOrDefault(s2[i], 0) - 1;
            }
            foreach (var k in map)
            {
                if (k.Value != 0) return false;
            }
            return true;
        }

        /// <summary>
        /// find-minimum-element-in-a-sorted-and-rotated-array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>

        public static int MinimumValue(int[] arr)
        {
            int lp = 0;
            int rp = arr.Length - 1;

            HashSet<int> hs = new HashSet<int>(arr);
            int[] uniqueArray = arr.Distinct().ToArray();
            while (lp < rp)
            {
                // The current subarray is already sorted, 
                // the minimum is at the low index
                if (arr[lp] < arr[rp])
                {
                    return arr[lp];
                }

                int mid = (lp + rp) / 2;
                if (arr[mid] > arr[rp])
                {
                    lp = mid + 1;
                }
                else rp = mid;
            }
            return arr[lp];
        }
    }

}
