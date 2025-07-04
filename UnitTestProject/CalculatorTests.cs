using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using ViewModel;

namespace UnitTestProject
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculateYWithMod()
        {
            NCalcFunctionCalculator calc = new NCalcFunctionCalculator();
            string typeOfFunc = AvailableFunctions.GetAvailableFunctionsList()[0];
            IFunction function = new FunctionWithOneCoef(typeOfFunc, -10, 10, new List<double>() { 3.0, 2, 3 });

            double result = calc.Calculate(function.Equation, 10);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CalculateYWithPow()
        {
            NCalcFunctionCalculator calc = new NCalcFunctionCalculator();
            string typeOfFunc = AvailableFunctions.GetAvailableFunctionsList()[1];
            IFunction function = new FunctionWithOneCoef(typeOfFunc, -10, 10, new List<double>() { 3.0, 2, 3 });

            double result = calc.Calculate(function.Equation, 10);

            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        public void CalculateYWithCos()
        {
            NCalcFunctionCalculator calc = new NCalcFunctionCalculator();
            string typeOfFunc = AvailableFunctions.GetAvailableFunctionsList()[3];
            IFunction function = new FunctionWithOneCoef(typeOfFunc, -10, 10, new List<double>() { 3.1, 2, 3 });

            double result = calc.Calculate(function.Equation, 1);
            double exp = Math.Cos(1);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void CalculateYWithSqrt()
        {
            double x = 100;
            NCalcFunctionCalculator calc = new NCalcFunctionCalculator();
            string typeOfFunc = AvailableFunctions.GetAvailableFunctionsList()[4];
            IFunction function = new FunctionWithOneCoef(typeOfFunc, -10, 10, new List<double>() { 3.1, 2, 3 });

            double result = calc.Calculate(function.Equation, x);
            double exp = Math.Sqrt(x);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void CalculateYWithLn()
        {
            double x = 100;
            NCalcFunctionCalculator calc = new NCalcFunctionCalculator();
            string typeOfFunc = AvailableFunctions.GetAvailableFunctionsList()[6];
            IFunction function = new FunctionWithOneCoef(typeOfFunc, -10, 10, new List<double>() { 3.1, 2, 3 });

            double result = calc.Calculate(function.Equation, x);
            double exp = Math.Log(x);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void CalculateYWithArccos()
        {
            double x = 100;
            NCalcFunctionCalculator calc = new NCalcFunctionCalculator();
            string typeOfFunc = AvailableFunctions.GetAvailableFunctionsList()[8];
            IFunction function = new FunctionWithOneCoef(typeOfFunc, -10, 10, new List<double>() { 3.1, 2, 3 });

            double result = calc.Calculate(function.Equation, x);
            double exp = Math.Acos(x);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void CalculateYWithArctg()
        {
            double x = 100;
            NCalcFunctionCalculator calc = new NCalcFunctionCalculator();
            string typeOfFunc = AvailableFunctions.GetAvailableFunctionsList()[9];
            IFunction function = new FunctionWithOneCoef(typeOfFunc, -10, 10, new List<double>() { 3.1, 2, 3 });

            double result = calc.Calculate(function.Equation, x);
            double exp = Math.Atan(x);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void CalculateYWithArcctg()
        {
            double x = 100;
            NCalcFunctionCalculator calc = new NCalcFunctionCalculator();
            string typeOfFunc = AvailableFunctions.GetAvailableFunctionsList()[10];
            IFunction function = new FunctionWithOneCoef(typeOfFunc, -10, 10, new List<double>() { 3.1, 2, 3 });

            double result = calc.Calculate(function.Equation, x);
            double exp = Math.PI / 2 - Math.Atan(x);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void CalculateYWithExp()
        {
            double x = 5;
            NCalcFunctionCalculator calc = new NCalcFunctionCalculator();
            string typeOfFunc = AvailableFunctions.GetAvailableFunctionsList()[17];
            IFunction function = new FunctionWithOneCoef(typeOfFunc, -10, 10, new List<double>() { 3.1, 2, 3 });

            double result = calc.Calculate(function.Equation, x);
            double exp = Math.Exp(x);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void CalculateYWithMany()
        {
            double x = 5;
            NCalcFunctionCalculator calc = new NCalcFunctionCalculator();
            string typeOfFunc = AvailableFunctions.GetAvailableFunctionsList()[13];
            IFunction function = new FunctionWithOneCoef(typeOfFunc, -10, 10, new List<double>() { 3.1, 2, 3 });

            double result = calc.Calculate(function.Equation, x);
            double exp = Math.Log(Math.Cos(x));
            Assert.AreEqual(exp, result);
        }
    }
}
