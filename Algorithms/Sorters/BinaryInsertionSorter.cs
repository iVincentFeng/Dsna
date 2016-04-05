using System;

namespace Dsna.Algorithms.Sorters
{
    public class BinaryInsertionSorter<TValue> : ISort<TValue> where TValue : IComparable
    {
        public void Sort(TValue[] array)
        {
            if ((array == null) || (array.Length == 0) || (array.Length == 1))
            {
                return;
            }

            for (int ixToBeSorted = 1; ixToBeSorted < array.Length; ixToBeSorted++)
            {
                TValue curToBeSorted = array[ixToBeSorted];

                int ixSortedLowerBound = 0;
                int ixSortedUpperBound = ixToBeSorted - 1;

                while (ixSortedLowerBound <= ixSortedUpperBound)
                {
                    int ixSortedMiddle = ixSortedLowerBound + (ixSortedUpperBound - ixSortedLowerBound) / 2;
                    int comparisonResult = curToBeSorted.CompareTo(array[ixSortedMiddle]);
                    if (comparisonResult == 0)
                    {
                        ixSortedLowerBound = ixSortedMiddle;
                        break;
                    }
                    else if (comparisonResult > 0)
                    {
                        ixSortedLowerBound = ixSortedMiddle + 1;
                    }
                    else
                    {
                        ixSortedUpperBound = ixSortedMiddle - 1;
                    }
                }

                int ixSorted = ixToBeSorted;
                while (ixSorted > ixSortedLowerBound)
                {
                    array[ixSorted] = array[ixSorted - 1];
                    ixSorted--;
                }

                array[ixSortedLowerBound] = curToBeSorted;
            }
        }
    }
}
