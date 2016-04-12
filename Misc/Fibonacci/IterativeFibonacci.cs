namespace Dsna.Misc.Fibonacci
{
    public class IterativeFibonacci : IFibonacci
    {
        public ulong CalculateFibonacci(uint number)
        {
            if ((number == 0) || (number == 1))
            {
                return number;
            }

            ulong prev1 = 0;
            ulong prev2 = 1;

            ulong result = 0;
            for (int ix = 2; ix <= number; ix++)
            {
                result = prev1 + prev2;

                prev1 = prev2;
                prev2 = result;
            }

            return result;
        }
    }
}
