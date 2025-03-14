using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class ValidateSequence
    {

        public static bool IsValidSequence(List<int>array, List<int>sequence)
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

            while(arrPtr<array.Count && seqPtr<sequence.Count)
            {
                if (array[arrPtr] == sequence[seqPtr]) seqPtr++;
                arrPtr++;
            }
            return seqPtr == sequence.Count;
        }
    }
}
