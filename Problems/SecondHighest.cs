using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class SecondHighest
    {
        //public static int FindSecondHighest2(int[] nums)
      //  {
            //int fH = 0, sH = -1;
            ////while(left>right)
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    if (nums[i] > nums[i + 1])
            //    {
            //        if (fH < nums[i])
            //        {
            //            fH = nums[i];
            //        }
            //        if (sH < nums[i + 1])
            //        {
            //            sH = nums[i + 1];
            //        }

            //    }
            //    else
            //    {
            //        if (sH < nums[i])
            //        {
            //            fH = nums[i + 1];
            //        }
            //        if (fH < nums[i + 1])
            //        {
            //            sH = nums[i];
            //        }
            //    }
            //    //else if (nums[i]>sH)
            //    //{
            //    //    sH = nums[i];
            //    //}
            //}
            //return sH;
       // }

        public static int FindSecondHighest(int[] nums)
        {
            if (nums ==null || nums.Length < 2) return -1;
            int fH = int.MinValue, sH = -1;
            for (int i = 0; i < nums.Length; i++)
            {                
                if (fH < nums[i])
                {  
                    fH = nums[i];  
                    
                }
                else if (nums[i] >sH && nums[i]!=fH)
                {                    
                    if (nums[i] <= fH)
                    {
                        sH = nums[i];
                    }

                }
            }
            return sH; 
        }
    }
}
