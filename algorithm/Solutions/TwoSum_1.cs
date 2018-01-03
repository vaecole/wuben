using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm.Solutions
{
    public class TwoSum_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> valuesInMind = new Dictionary<int, int>();
            for (int i = 0, length = nums.Length; i < length; i++)
            {
                var firstValue = target - nums[i];
                if (valuesInMind.ContainsKey(firstValue))
                {
                    return new int[] { valuesInMind[firstValue], i };
                }
                valuesInMind[nums[i]] = i;
            }
            throw new Exception("No solution");
        }

        public int[] TwoSumOnn_O1(int[] nums, int target)
        {
            int f = -1, s = -1;
            bool breakFlag = false;
            for (int i = 0; i < nums.Length && !breakFlag; i++)
            {
                for (int j = nums.Length - 1; j > i; j--)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        f = i;
                        s = j;
                        breakFlag = true;
                        break;
                    }
                }
            }
            return new int[] { f, s };
        }
    }
}
