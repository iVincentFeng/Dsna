using System;

namespace Dsna.LeetCode.MinSubArraySumLen
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-size-subarray-sum/
    /// </summary>
    public class MinSubArraySumLenWithSlidingWindow : IGetMinSubArraySumLen
    {
        public uint GetMinSubArraySumLen(uint[] nums, uint sum)
        {
            if ((nums == null) || (nums.Length == 0))
            {
                return 0;
            }

            uint ixLeft = 0;
            uint ixRight = 0;
            ulong tempSum = 0;
            uint result = uint.MaxValue;

            while (ixRight < nums.Length)
            {
                tempSum += nums[ixRight++];

                while (tempSum >= sum)
                {
                    result = Math.Min(result, ixRight - ixLeft);

                    tempSum -= nums[ixLeft++];
                }
            }

            return (result == uint.MaxValue) ? 0 : result;
        }
    }
}
