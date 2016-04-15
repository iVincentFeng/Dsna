using System;

namespace Dsna.LeetCode.PowerOfNumber
{
    /// <summary>
    /// https://leetcode.com/problems/powx-n/
    /// </summary>
    /// <notes>
    ///   1. Equality of doubles
    ///   2. What if x is zero and n is negative?
    ///   3. What is x is zero and n is not zero?
    ///   4. What if x is not zero and n is negative?
    ///   5. What if x is not zero and n is int.MinValue?
    ///   6. What if x is not zero and n is zero?
    ///   7. What if the result exceeds [double.MinValue, double.MaxValue]?
    /// </notes>
    public class PowerOfNumber
    {
        public double Power(double number, int power)
        {
            if (this.IsEqual(number, 0.00d))
            {
                if (power < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    return 0.00d;
                }
            }
            else
            {
                if (power == 0)
                {
                    return 1.00d;
                }
            }

            long longPower = power;
            
            bool isNegativePower = (longPower < 0);
            if (isNegativePower)
            {
                longPower = -longPower;
            }

            double result = this.DoPower(number, longPower);

            if (isNegativePower)
            {
                result = 1.00d / result;
            }

            return result;
        }

        private double DoPower(double number, long power)
        {
            if (power == 0)
            {
                return 1.00d;
            }

            if (power == 1)
            {
                return number;
            }

            double result = this.DoPower(number, power / 2);
            result *= result;
            if (power % 2 != 0)
            {
                result *= number;
            }

            return result;
        }

        private bool IsEqual(double x, double y)
        {
            if (Math.Abs(x - y) < 0.000001)
            {
                return true;
            }

            return false;
        }
    }
}
