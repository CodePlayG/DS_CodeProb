using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Fibonacci
    {

        /// <summary>
        /// recursive approach to get number of fib searies at the provided number (num) in the input
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int FibNum(int num)
        {
            return num <= 2 ? 1 : FibNum(num - 2) + FibNum(num - 1);
        }
        /// <summary>
        /// space complexity o(1) as no array creation
        /// Time Complexity o(n) as loop for 2 to n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fib(int n)
        {

            if (n <= 1) return n;
            int pre1 = 0;
            int pre2 = 1;
            int next = 0;
            for(int i=2;i<=n;i++)
            {
                next = pre1 + pre2;
                pre1 = pre2;
                pre2 = next;
                
            }
            return next;
        }

        /// <summary>
        /// Using while loop/or recursive way of doing is not the optimal way of doing as it takes a O(2^n) times. 
        /// A better way to do this is using what is already in memory like below. This should take at most O(n) time
        /// space is O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>        
        public static double fibDynamic(int n)
        {
            if (n <= 1) return n;
           // if (n == 1) return 1;
            double[] array = new double[n+1];
            array[0] = 0;
            array[1] = 1;
                
            for (int i = 2; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            return array[n];
        }

        /// <summary>
        /// series upto given number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string FibCal(int n)
        {
            string series = "";
            int k, f1=0, f2=1, f = 0;
            f1 = 0; f2 = 1;
            if (n < 2)
                return n.ToString();
            else
                for (k = 2; k <= n; k++)
                {
                    f = f1 + f2;
                    f1 = f2;
                    f2 = f;
                    series += f.ToString() + ",";
                }

            return series;
        }
        public static List<int>FibSeries(int n)
        {
            if (n <= 0) return new List<int> { };
            if (n == 1) return new List<int> { 0 };
            List<int> series = new();
            if (n >= 2)
            {
                int p1 = 0, p2 = 1, current = 0;
                
                series.Add(p1);
                series.Add(p2);
                for (int i = 3; i <= n; i++)
                {
                    current = p1 + p2;
                    p1 = p2;
                    p2 = current;
                    series.Add(current);

                }
            }
            return series;
        }

    }
}





