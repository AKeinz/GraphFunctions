using Model;
using System.Collections.Generic;

namespace ViewModel.FunctionFactory
{
    internal class FucntionWithThreeCoefFactory : IFunctionFactory
    {
        public IFunction CreateFunction(string type, List<double> coefs, (double min, double max) interval)
        => new FunctionWithThreeCoef(type, interval.min, interval.max, coefs);
    }
}
