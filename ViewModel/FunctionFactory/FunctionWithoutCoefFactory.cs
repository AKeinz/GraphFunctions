using Model;
using System.Collections.Generic;

namespace ViewModel.FunctionFactory
{
    internal class FunctionWithoutCoefFactory : IFunctionFactory
    {
        public IFunction CreateFunction(string type, List<double> coefs, (double min, double max) interval)
        => new FunctionWithouCoef(type, interval.min, interval.max);
    }
}
