using Dsna.Algorithms.Shared;
using System;

namespace Dsna.Algorithms.Sorters
{
    public class QuickSorter<TValue> : ISort<TValue> where TValue : IComparable
    {
        public QuickSorter(ISelectPivot<TValue> pivotSelector)
        {
            this.pivotSelector = pivotSelector;
        }
        
        public void Sort(TValue[] array)
        {
            if ((array == null) || (array.Length == 0) || (array.Length == 1))
            {
                return;
            }

            this.DoSort(array, 0, array.Length - 1);
        }

        private void DoSort(TValue[] array, int lowerBound, int upperBound)
        {
            if (lowerBound < upperBound)
            {
                // Loop invariant: items in left sub-array are smaller than pivot, while the ones in right sub-array are greater than pivot.
                int ixPivot = this.Partition(array, lowerBound, upperBound);
                this.DoSort(array, lowerBound, ixPivot - 1);
                this.DoSort(array, ixPivot + 1, upperBound);
            }
        }

        private int Partition(TValue[] array, int lowerBound, int upperBound)
        {
            int pivotIndex = this.pivotSelector.SelectPivot(array, lowerBound, upperBound);
            this.Swap(array, pivotIndex, lowerBound);

            TValue pivot = array[lowerBound];

            int ixLeft = lowerBound;
            for (int ixRight = lowerBound + 1; ixRight <= upperBound; ixRight++)
            {
                if (pivot.CompareTo(array[ixRight]) > 0)
                {
                    this.Swap(array, ++ixLeft, ixRight);
                }
            }

            this.Swap(array, lowerBound, ixLeft);

            return ixLeft;
        }

        private void Swap(TValue[] array, int indexA, int indexB)
        {
            if (indexA != indexB)
            {
                TValue temp = array[indexA];
                array[indexA] = array[indexB];
                array[indexB] = temp;
            }
        }

        private ISelectPivot<TValue> pivotSelector = null;
    }
}
