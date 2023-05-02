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
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = nums[nums[i]];
            return array;

        }

        static public string DefangIPaddr(string address)
        {
            string str = address.Replace(".", "[.]");
            return str;
        }



        static void Main(string[] args)
        {
            //1 Задание
            int[] nums = { 0, 2, 1, 5, 3, 4 };
         
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }
            Console.WriteLine();

            int[] newArr = BuildArray(nums);
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i]);
            }
            Console.WriteLine();

            //2 Задание
            string address = "1.1.1.1";
            Console.WriteLine(DefangIPaddr(address));




        }
    }
}
