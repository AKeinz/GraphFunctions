using Model;
using System.Collections.Generic;

namespace ViewModel.FunctionFactory
{
    internal class FunctionWithOneCoefFactory : IFunctionFactory
    {
        public IFunction CreateFunction(string type, List<double> coefs, (double min, double max) interval)
        => new FunctionWithOneCoef(type, interval.min, interval.max, coefs);
    }
}
