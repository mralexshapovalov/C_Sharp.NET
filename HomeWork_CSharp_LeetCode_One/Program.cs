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
            int product = 1;
            int c=0;

            for(int i = 0; i < nums.Length; i++)
            {
                 product*= nums[i];
            }

           

            if(product==0)
            {
                c= 0;
            }
            if(product>=1)
            {
                c= 1;
            }
            if(-1 < product)
            {
                c= -1;
            }


            return c;

        }


        static void Main(string[] args)
        {
            ////1 Задание
            //int[] nums = { 0, 2, 1, 5, 3, 4 };

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write(nums[i]);
            //}
            //Console.WriteLine();

            //int[] newArr = BuildArray(nums);
            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    Console.Write(newArr[i]);
            //}
            //Console.WriteLine();

            ////2 Задание
            //string address = "1.1.1.1";
            //Console.WriteLine(DefangIPaddr(address));

            int[] nums = { -1, -2, -3, -4, 3, 2, 1 };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }
            Console.WriteLine();

           
           
            
            Console.Write(ArraySign(nums));
            
        

        }
    }
}
