using System.Collections.Generic;

namespace Dsna.Misc.Fibonacci
{
    public class RecursiveFibonacciWithCache : IFibonacci
    {
        public ulong CalculateFibonacci(uint number)
        {
            cache.Clear();

            cache.Add(0, 0);
            cache.Add(1, 1);

            return this.DoCalculateFibonacci(number);
        }

        private ulong DoCalculateFibonacci(uint number)
        {
            if (cache.ContainsKey(number))
            {
                return cache[number];
            }

            ulong result = this.DoCalculateFibonacci(number - 1) + this.DoCalculateFibonacci(number - 2);

            cache.Add(number, result);

            return result;
        }

        private Dictionary<uint, ulong> cache = new Dictionary<uint, ulong>();
    }
}
