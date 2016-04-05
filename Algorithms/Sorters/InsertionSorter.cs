using System;

namespace Dsna.Algorithms.Sorters
{
    public class InsertionSorter<TValue> : ISort<TValue> where TValue : IComparable
    {
        public void Sort(TValue[] array)
        {
            if ((array == null) || (array.Length == 0) || (array.Length == 1))
            {
                return;
            }

            // Loop invariant: items in left sub-array are already sorted
            for (int ixToBeSorted = 1; ixToBeSorted < array.Length; ixToBeSorted++)
            {
                TValue curToBeSorted = array[ixToBeSorted];
                int ixSorted = ixToBeSorted - 1;

                while ((ixSorted >= 0) && (curToBeSorted.CompareTo(array[ixSorted]) < 0))
                {
                    array[ixSorted + 1] = array[ixSorted];
                    
                    ixSorted--;
                }

                array[ixSorted + 1] = curToBeSorted;
            }
        }
    }
}
