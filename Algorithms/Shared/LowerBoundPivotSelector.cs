using System;

namespace Dsna.Algorithms.Shared
{
    public class LowerBoundPivotSelector<TValue> : ISelectPivot<TValue> where TValue : IComparable
    {
        public int SelectPivot(TValue[] array, int lowerBound, int upperBound)
        {
            return lowerBound;
        }
    }
}
