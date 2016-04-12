namespace Dsna.Misc.Fibonacci
{
    public class RecursiveFibonacci : IFibonacci
    {
        public ulong CalculateFibonacci(uint number)
        {
            if ((number == 0) || (number == 1))
            {
                return number;
            }

            return this.CalculateFibonacci(number - 1) + this.CalculateFibonacci(number - 2);
        }
    }
}
