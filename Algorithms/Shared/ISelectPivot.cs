using System;

namespace Dsna.Algorithms.Shared
{
    public interface ISelectPivot<TValue> where TValue : IComparable
    {
        int SelectPivot(TValue[] array, int lowerBound, int upperBound);
    }
}
