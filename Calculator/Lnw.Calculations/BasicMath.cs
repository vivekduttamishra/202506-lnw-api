using ConceptArchitect.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lnw.Calculations
{
    public class BasicMath
    {
        [ArithmeticOperator(Alias = ["remainder"], Help ="Finds remainder on division of x by y")]
        public static double Mod(double x, double y) { return x % y; }

        [ArithmeticOperator(Alias =["int-div"], Help ="Calculates only int division ignoring fractional parts")]
        public static double IntDiv(double x, double y) {  return (int)x/ (int)y; }

        public static double FindPrimes(double min, double max)
        {
            var count = 0;
            for(var i = min; i < max; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }

            }
            return count;
        }

        private static bool IsPrime(double n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
