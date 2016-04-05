using System;

namespace Dsna.Algorithms.Sorters
{
    public interface ISort<TValue>
        where TValue : IComparable
    {
        void Sort(TValue[] array);
    }
}