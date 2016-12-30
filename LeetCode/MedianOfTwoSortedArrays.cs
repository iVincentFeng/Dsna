using System;

namespace Dsna.LeetCode
{
    public class MedianOfTwoSortedArrays
    {
        public double Resolve(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length;
            int len2 = nums2.Length;

            // To achieve T(n) = log(min(len1, len2))
            if (len1 > len2)
            {
                return this.Resolve(nums2, nums1);
            }

            int ix1 = 0;
            int ix1Min = 0;
            int ix1Max = len1;

            int midLen = (len1 + len2 + 1) / 2;

            int ix2 = 0;

            // Binary search
            while (ix1Min <= ix1Max)
            {
                ix1 = ix1Min + (ix1Max - ix1Min) / 2;
                ix2 = midLen - ix1;

                if ((ix1 == 0) || (ix2 == len2) ||
                    ((nums1[ix1 - 1] <= nums2[ix2]) && (nums2[ix2 - 1] <= nums1[ix1])))
                {
                    break;
                }
                else if ((ix1 > 0) && (ix2 < len2) && (nums1[ix1 - 1] > nums2[ix2]))
                {
                    ix1Max = ix1 - 1;
                }
                else if ((ix1 < len1) && (ix2 > 0) && (nums2[ix2 - 1] > nums1[ix1]))
                {
                    ix1Min = ix1 + 1;
                }
            }

            int maxLeft = 0;
            if (ix1 == 0)
            {
                maxLeft = nums2[ix2 - 1];
            }
            else if (ix2 == 0)
            {
                maxLeft = nums1[ix1 - 1];
            }
            else
            {
                maxLeft = Math.Max(nums1[ix1 - 1], nums2[ix2 - 1]);
            }

            // If len1 + len2 is odd
            if ((len1 + len2) / 2 == 1)
            {
                return maxLeft;
            }

            int minRight = 0;
            if (ix1 == len1)
            {
                minRight = nums2[ix2];
            }
            else if (ix2 == len2)
            {
                minRight = nums1[ix1];
            }
            else
            {
                minRight = Math.Min(nums1[ix1], nums2[ix2]);
            }

            return (maxLeft + minRight) / 2.0;
        }
    }
}
