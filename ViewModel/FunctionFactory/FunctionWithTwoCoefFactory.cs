using Model;
using System.Collections.Generic;

namespace ViewModel.FunctionFactory
{
    internal class FunctionWithTwoCoefFactory : IFunctionFactory
    {
        public IFunction CreateFunction(string type, List<double> coefs, (double min, double max) interval)
        => new FunctionWithTwoCoef(type, interval.min, interval.max, coefs);
    }
}
