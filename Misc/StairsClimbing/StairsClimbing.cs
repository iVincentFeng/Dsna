namespace Dsna.Misc.StairsClimbing
{
    public class StairsClimbing
    {
        public ulong ClimbStairs(uint stairsSteps)
        {
            if (stairsSteps <= 2)
            {
                return stairsSteps;
            }

            ulong prev1 = 1;
            ulong prev2 = 2;

            ulong result = 0;

            for (int ix = 3; ix <= stairsSteps; ix++)
            {
                result = prev1 + prev2;

                prev1 = prev2;
                prev2 = result;
            }

            return result;
        }
    }
}
