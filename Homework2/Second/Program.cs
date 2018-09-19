using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            int max(int []A,int num)
            {
                for (int i = 0; i < (num-1); i++)
                {
                    if (A[i] > A[i + 1])
                        A[i + 1] = A[1];
                }
                return A[num - 1];
            }
            int min(int []A,int num)
            {
                for(int i = 0; i < (num - 1); i++)
                {
                    if (A[i] < A[i + 1])
                        A[i + 1] = A[i];
                }
                return A[num - 1];
            }
            int ave(int[]A,int num)
            {
                int a=0;
                for (int i = 0; i < num; i++)
                {
                    a = a + A[i];
                }
                return a / num;
            }
            int add(int[] A,int num)
            {
                int a = 0;
                for (int i = 0; i < num; i++)
                {
                    a = a + A[i];
                }
                return a;
            }
            int[] array=null;
            Console.WriteLine("Please Write Down How Many Num You Want To Input ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("请输入");
               array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int M = max(array, n);
            int m = min(array, n);
            int average = ave(array, n);
            int ad = add(array, n);
            Console.WriteLine("max:" + M + '\n' + "min:" + m + '\n' + "average:" + average + '\n');
            Console.WriteLine("sum:" + ad);
        }
    }
}
