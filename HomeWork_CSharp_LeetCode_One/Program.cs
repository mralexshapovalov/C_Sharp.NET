//#define TASK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#if TASK
Решить две задачи с leetcode.
https://leetcode.com/problems/build-array-from-permutation/ - на массивы
https://leetcode.com/problems/defanging-an-ip-address/ - на строки  
#endif


namespace HomeWork_CSharp_LeetCode_One
{
    internal class Program
    {
        static public int[] BuildArray(int[] nums)
        {
            int length = nums.Length;
            int[] ans = new int[length];

            for (int i = 0; i < length; i++)
            {
                ans[i] = nums[nums[i]];
            }
                
            return ans;
        }

        static public string DefangIPaddr(string address)
        {
            string str = address.Replace(".", "[.]");
            return str;
        }

        static public int ArraySign(int[] nums)
        {
            int product=1;
          
            for(int i = 0; i < nums.Length; i++)
            {    
                 product*= nums[i];

                if (product == 0)
                {

                    product = 0;
                }

                else if (product >= 1)
                {
                    product = 1;
                }

                else if (product < -1)
                {
                    product = -1;
                }

            }

            return product;
        }

        static public int SumOddLengthSubarrays(int[] arr)
        {
        //1588. Sum of All Odd Length Subarrays

           //Input: arr = [1, 4, 2, 5, 3]
          //Output: 58
          //Explanation: The odd-length subarrays of arr and their sums are:
//            [1] = 1
//            [4] = 4
//            [2] = 2
//            [5] = 5
//            [3] = 3
//            [1, 4, 2] = 7
//            [4, 2, 5] = 11
//            [2, 5, 3] = 10
//            [1, 4, 2, 5, 3] = 15
//If we add all these together we get 1 + 4 + 2 + 5 + 3 + 7 + 11 + 10 + 15 = 58
            int sum = 0;
            int sum1 = 0;
            int sum3 = 0;

            for(int i=0;i<arr.Length;i++)
            {
                sum+=arr[i];

               

            }

            for(int i=0;i<arr.Length;i++)
            { 
                Console.WriteLine(arr[i]);
                sum1+=arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length-1; j++)
                {
                    sum3 = arr[i] + arr[j];
                   
                }
                
                
               



            }










            return sum3+sum+sum1;
            
        }


        static void Main(string[] args)
        {

            int[] nums = { 1, 4, 2, 5,3 };

            Console.Write(SumOddLengthSubarrays(nums)+"\t");
        }
    }
}
