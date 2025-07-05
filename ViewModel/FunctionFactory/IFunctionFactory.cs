using Model;
using System.Collections.Generic;

namespace ViewModel.FunctionFactory
{
    internal interface IFunctionFactory
    {
        IFunction CreateFunction(string type, List<double> coefs, (double min, double max) interval);
    }
}
