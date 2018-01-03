using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm.Solutions
{
    class ThreeSumClosest_16
    {
        /// <summary>
        /// O(n*n*n), 37%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int ThreeSumClosest(int[] nums, int target)
        {
            int res = target;
            int min = int.MaxValue;
            for (int i = 0, length = nums.Length; i < length - 2; i++)
            {
                for (int j = i + 1; j < length - 1; j++)
                {
                    int iPlusJ = nums[i] + nums[j];
                    for (int k = j + 1; k < length; k++)
                    {
                        int candidate = iPlusJ + nums[k];
                        int candMin = Math.Abs(candidate - target);
                        if (candMin < min)
                        {
                            min = candMin;
                            if (min == 0)
                            {
                                return candidate;
                            }
                            res = candidate;
                        }
                    }
                }
            }
            return res;
        }

        // TODO sort first, and test x1+x2+xn, x1+x2+xn-1, ..., x1+x2+x(min), ...,  xa+xb+xc more than target
    }
}
