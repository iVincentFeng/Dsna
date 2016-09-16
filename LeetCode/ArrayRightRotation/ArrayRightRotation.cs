namespace Dsna.LeetCode.ArrayRightRotation
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-array/
    /// </summary>
    /// <typeparam name="TValue">Type of value</typeparam>
    public class ArrayRightRotation<TValue> : IRightRotateArray<TValue>
    {
        public void RightRotateArray(TValue[] array, int offset)
        {
            if ((array == null) || (array.Length == 0) || (offset <= 0))
            {
                return;
            }

            int arrayLen = array.Length;
            offset %= arrayLen;
            if (offset == 0)
            {
                return;
            }

            this.Reverse(array, 0, arrayLen - offset - 1);
            this.Reverse(array, arrayLen - offset, arrayLen - 1);
            this.Reverse(array, 0, arrayLen - 1);
        }

        private void Reverse(TValue[] array, int lowerBound, int upperBound)
        {
            while (lowerBound < upperBound)
            {
                TValue temp = array[lowerBound];
                array[lowerBound] = array[upperBound];
                array[upperBound] = temp;

                lowerBound++;
                upperBound--;
            }
        }
    }
}
