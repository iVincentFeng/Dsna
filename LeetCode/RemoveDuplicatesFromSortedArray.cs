namespace Dsna.LeetCode
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int Resolve(int[] nums)
        {
            if ((nums == null) || (nums.Length == 0))
            {
                return 0;
            }

            int ixBehind = 0;
            int ixAhead = 1;

            while (ixAhead < nums.Length)
            {
                if (nums[ixAhead] == nums[ixBehind])
                {
                    ixAhead++;
                }
                else
                {
                    nums[++ixBehind] = nums[ixAhead++];
                }
            }

            return ixBehind + 1;
        }
    }
}
