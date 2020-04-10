using System;
using System.Collections.Generic;
using System.Linq;

namespace TestAppForLeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var excel = new Excel();
            var res = excel.ConvertToTitle(702);
            // var res = TwoSum4(new int[] { 2, 7, 11, 15 }, 9);
            // Console.WriteLine("Hello World!");
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return new int[] { 0, 0 };
        }

        public static int[] TwoSum2(int[] numbers, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
                map.Add(numbers[i], i);

            for (int i = 0; i < numbers.Length; i++)
            {
                var complement = target - numbers[i];
                if (map.ContainsKey(complement) && map.GetValueOrDefault(complement) != i)
                    return new int[] { i, map.GetValueOrDefault(complement) };
            }
            return new int[] { 0, 0 };
        }

        public static int[] TwoSum3(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target && numbers[i] > 0)
                    return new int[] { 0, 0 };
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                        return new int[] { i + 1, j + 1 };
                }
            }
            return new int[] { 0, 0 };
        }

        public static int[] TwoSum4(int[] numbers, int target)
        {
            int i = 0, j = numbers.Length - 1, sum;
            while (i < j)
            {
                sum = numbers[i] + numbers[j];
                if (sum == target)
                    return new int[] { ++i, ++j };
                else if (sum < target)
                    i++;
                else
                    j--;
            }
            return null;
        }
    }
}
