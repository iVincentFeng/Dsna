using System;

namespace Dsna.Algorithms.Sorters
{
    public class MergeSorter<TValue> : ISort<TValue> where TValue : IComparable
    {
        public void Sort(TValue[] array)
        {
            if ((array == null) || (array.Length == 0) || (array.Length == 1))
            {
                return;
            }

            TValue[] buffer = new TValue[array.Length];

            this.DoSort(array, 0, array.Length - 1, buffer);
        }

        private void DoSort(TValue[] array, int lowerBound, int upperBound, TValue[] buffer)
        {
            if (lowerBound < upperBound)
            {
                int ixMiddle = lowerBound + (upperBound - lowerBound) / 2;
                this.DoSort(array, lowerBound, ixMiddle, buffer);
                this.DoSort(array, ixMiddle + 1, upperBound, buffer);
                this.MergeArray(array, lowerBound, ixMiddle, upperBound, buffer);
            }
        }

        private void MergeArray(TValue[] array, int lowerBound, int middleIndex, int upperBound, TValue[] buffer)
        {
            int ixLeft = lowerBound;
            int ixRight = middleIndex + 1;
            int ixBuffer = lowerBound;

            while ((ixLeft <= middleIndex) && (ixRight <= upperBound))
            {
                if (array[ixLeft].CompareTo(array[ixRight]) < 0)
                {
                    buffer[ixBuffer] = array[ixLeft];
                    ixLeft++;
                }
                else
                {
                    buffer[ixBuffer] = array[ixRight];
                    ixRight++;
                }

                ixBuffer++;
            }

            while (ixLeft <= middleIndex)
            {
                buffer[ixBuffer] = array[ixLeft];
                ixLeft++;
                ixBuffer++;
            }

            while (ixRight <= upperBound)
            {
                buffer[ixBuffer] = array[ixRight];
                ixRight++;
                ixBuffer++;
            }

            ixBuffer = lowerBound;
            while (ixBuffer <= upperBound)
            {
                array[ixBuffer] = buffer[ixBuffer];
                ixBuffer++;
            }
        }
    }
}
