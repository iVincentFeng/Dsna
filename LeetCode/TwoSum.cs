using System.Collections.Generic;

namespace Dsna.LeetCode
{
    public class TwoSum
    {
        public int[] Resolve(int[] nums, int target)
        {
            int[] result = new int[2];

            if ((nums == null) || (nums.Length == 0))
            {
                return result;
            }

            Dictionary<int, int> numIdxMappings = new Dictionary<int, int>();
            for (int ix = 0; ix < nums.Length; ix++)
            {
                numIdxMappings[nums[ix]] = ix;
            }

            for (int ix = 0; ix < nums.Length; ix++)
            {
                int num = nums[ix];

                if (!numIdxMappings.ContainsKey(target - num))
                {
                    continue;
                }

                int ix2 = numIdxMappings[target - num];

                if (ix == ix2)
                {
                    continue;
                }

                result[0] = ix;
                result[1] = ix2;

                break;
            }

            return result;
        }
    }
}
