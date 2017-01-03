using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsna.LeetCode
{
    public class ContainerWithMostWater
    {
        public long Resolve(int[] heights)
        {
            long maxArea = 0;

            if ((heights == null) || (heights.Length == 0))
            {
                return maxArea;
            }

            int ixLow = 0;
            int ixHigh = heights.Length - 1;

            while (ixLow < ixHigh)
            {
                int curHeight = Math.Min(heights[ixLow], heights[ixHigh]);
                int curWidth = ixHigh - ixLow;

                maxArea = Math.Max(maxArea, curWidth * curHeight);

                // Skip lines at both ends that don't support a higher height.
                while ((heights[ixLow] <= curHeight) && (ixLow < ixHigh))
                {
                    ixLow++;
                }

                while ((heights[ixHigh] <= curHeight) && (ixLow < ixHigh))
                {
                    ixHigh--;
                }
            }

            return maxArea;
        }
    }
}
