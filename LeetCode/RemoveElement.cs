namespace Dsna.LeetCode
{
    public class RemoveElement
    {
        public int Resolve(int[] nums, int val)
        {
            if ((nums == null) || (nums.Length == 0))
            {
                return 0;
            }

            int ixBehind = 0;
            int ixAhead = 0;

            while (ixAhead < nums.Length)
            {
                if (nums[ixAhead] == val)
                {
                    ixAhead++;
                }
                else
                {
                    nums[ixBehind++] = nums[ixAhead++];
                }
            }

            return ixBehind;
        }
    }
}
