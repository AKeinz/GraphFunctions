using Model;
using System;
using System.Collections.Generic;

namespace ViewModel.FunctionFactory
{
    public static class FunctionFactory
    {

        private static readonly Dictionary<int, IFunctionFactory> _factories = new Dictionary<int, IFunctionFactory>()
        {
            { 0, new FunctionWithoutCoefFactory() },
            { 1, new FunctionWithOneCoefFactory() },
            { 2, new FunctionWithTwoCoefFactory()},
            { 3, new FucntionWithThreeCoefFactory() }
        };

        public static IFunction CreateFunction(string type, List<double> coefs, (double min, double max) interval)
        {
            int key = AvailableFunctions.GetAvailableFunctionsDict()[type];
            if (!_factories.TryGetValue(key, out var factory))
            {
                throw new ArgumentException($"Функция не распознана: {type}");
            }

            return factory.CreateFunction(type, coefs, interval);
        }
    }
}
