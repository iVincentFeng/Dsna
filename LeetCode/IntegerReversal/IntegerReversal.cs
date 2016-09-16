using System;

namespace Dsna.LeetCode.IntegerReversal
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer/
    /// </summary>
    /// <notes>
    ///   1. What if provided x is negative?
    ///   2. What if provided x is negative and equal to int.MinValue?
    ///   3. What if the result exceeds int.MinValue or int.MaxValue?
    /// </notes>
    public class IntegerReversal
    {
        public int ReverseInteger(int x)
        {
            long lx = x;
            
            bool isNegative = (lx < 0);
            if (isNegative)
            {
                lx = Math.Abs(lx);
            }

            long result = 0;

            while (lx != 0)
            {
                result = result * 10 + lx % 10;
                lx /= 10;
            }

            if (isNegative)
            {
                result = -result;
            }

            if (result > int.MaxValue)
            {
                result = int.MaxValue;
            }

            if (result < int.MinValue)
            {
                result = int.MinValue;
            }

            return (int)result;
        }
    }
}
