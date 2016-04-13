using System;
using System.Collections.Generic;

namespace Dsna.LeetCode.MinSubArraySumLen
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-size-subarray-sum/
    /// </summary>
    public class MinSubArraySumLenWithBacktracking : IGetMinSubArraySumLen
    {
        public uint GetMinSubArraySumLen(uint[] nums, uint sum)
        {
            if ((nums == null) || (nums.Length == 0))
            {
                return 0;
            }

            uint minLen = uint.MaxValue;
            Stack<uint> path = new Stack<uint>();

            this.DoGetMinSubArraySumLen(nums, sum, 0, 0, ref minLen, path);

            return minLen;
        }

        private void DoGetMinSubArraySumLen(uint[] nums, uint sum, uint depth, uint actualSum, ref uint minLen, Stack<uint> path)
        {
            if (actualSum >= sum)
            {
                minLen = Math.Min(minLen, (uint)path.Count);
                
                return;
            }

            if (depth == nums.Length)
            {
                return;
            }

            if (actualSum + nums[depth] <= sum)
            {
                path.Push(nums[depth]);
                actualSum += nums[depth];

                this.DoGetMinSubArraySumLen(nums, sum, depth + 1, actualSum, ref minLen, path);

                path.Pop();
                actualSum -= nums[depth];
            }

            this.DoGetMinSubArraySumLen(nums, sum, depth + 1, actualSum, ref minLen, path);
        }
    }
}
