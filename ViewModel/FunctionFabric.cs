using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public static class FunctionFabric
    {
        public static IFunction CreateFunction(string type, List<double> coefs, (double min, double max) interval)
        {
            IFunction function;
            int countOfCoefficients = AvailableFunctions.GetAvailableFunctionsDict()[type];

            if (countOfCoefficients == 1)
            {
                function = new FunctionWithOneCoef(type, interval.min, interval.max, coefs);
            }
            else if (countOfCoefficients == 2)
            {
                function = new FunctionWithTwoCoef(type, interval.min, interval.max, coefs);
            }
            else if (countOfCoefficients == 3)
            {
                function = new FunctionWithThreeCoef(type, interval.min, interval.max, coefs);
            }
            else
            {
                function = new FunctionWithouCoef(type, interval.min, interval.max);
            }

            return function;
        }
    }
}
