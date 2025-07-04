using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using ViewModel;

namespace UnitTestProject
{
    [TestClass]
    public class AddFunctionUnitTest
    {
        [TestMethod]
        public void AddFunctionWithOneCoef()
        {
            double min = -12;
            double max = 12;
            double a = 10;
            double b = 1;
            double c = 9;
            string type = "y = x^[a]";
            AddFunctionViewModel viewModel = new AddFunctionViewModel();
            IFunction newFunction = new FunctionWithOneCoef(type, min, max, new List<double>() { a, b, c});
            viewModel.CurrentGraph.SelectedFunction = newFunction;
            viewModel.MinLimit = min;
            viewModel.MaxLimit = max;
            viewModel.ACoef = a;
            viewModel.BCoef = b;    
            viewModel.CCoef = c;

            viewModel.AddFunctionCommand.Execute(newFunction.Type);

            Assert.AreEqual(min, viewModel.CurrentGraph.SelectedFunction.MinLimit);
            Assert.AreEqual(max, viewModel.CurrentGraph.SelectedFunction.MaxLimit);
            Assert.AreEqual(type, viewModel.CurrentGraph.SelectedFunction.Type);
            Assert.AreEqual("y = x^10", viewModel.CurrentGraph.SelectedFunction.Equation);

        }

        [TestMethod]
        public void AddFunctionWithTwoCoef()
        {
            double min = -12;
            double max = 12;
            double a = 10;
            double b = 1;
            double c = 9;
            string type = "y = [a]*x^3+[b]*x^2";
            AddFunctionViewModel viewModel = new AddFunctionViewModel();
            IFunction newFunction = new FunctionWithTwoCoef(type, min, max, new List<double>() { a, b, c });
            viewModel.CurrentGraph.SelectedFunction = newFunction;
            viewModel.MinLimit = min;
            viewModel.MaxLimit = max;
            viewModel.ACoef = a;
            viewModel.BCoef = b;
            viewModel.CCoef = c;

            viewModel.AddFunctionCommand.Execute(newFunction.Type);

            Assert.AreEqual(min, viewModel.CurrentGraph.SelectedFunction.MinLimit);
            Assert.AreEqual(max, viewModel.CurrentGraph.SelectedFunction.MaxLimit);
            Assert.AreEqual(type, viewModel.CurrentGraph.SelectedFunction.Type);
            Assert.AreEqual("y = 10*x^3+1*x^2", viewModel.CurrentGraph.SelectedFunction.Equation);
        }

        [TestMethod]
        public void AddFunctionWithThreeCoef()
        {
            double min = -12;
            double max = 12;
            double a = 10;
            double b = 1;
            double c = 9;
            string type = "y = [a]*Sin(x*[b])+[c]";
            AddFunctionViewModel viewModel = new AddFunctionViewModel();
            IFunction newFunction = new FunctionWithThreeCoef(type, min, max, new List<double>() { a, b, c });
            viewModel.CurrentGraph.SelectedFunction = newFunction;
            viewModel.MinLimit = min;
            viewModel.MaxLimit = max;
            viewModel.ACoef = a;
            viewModel.BCoef = b;
            viewModel.CCoef = c;

            viewModel.AddFunctionCommand.Execute(newFunction.Type);

            Assert.AreEqual(min, viewModel.CurrentGraph.SelectedFunction.MinLimit);
            Assert.AreEqual(max, viewModel.CurrentGraph.SelectedFunction.MaxLimit);
            Assert.AreEqual(type, viewModel.CurrentGraph.SelectedFunction.Type);
            Assert.AreEqual("y = 10*Sin(x*1)+9", viewModel.CurrentGraph.SelectedFunction.Equation);
        }

        [TestMethod]
        public void AddFunctionWithNoCoef()
        {
            double min = -12;
            double max = 12;
            double a = 10;
            double b = 1;
            double c = 9;
            string type = "y = Cos(x)";
            AddFunctionViewModel viewModel = new AddFunctionViewModel();
            IFunction newFunction = new FunctionWithouCoef(type, min, max);
            viewModel.CurrentGraph.SelectedFunction = newFunction;
            viewModel.MinLimit = min;
            viewModel.MaxLimit = max;
            viewModel.ACoef = a;
            viewModel.BCoef = b;
            viewModel.CCoef = c;

            viewModel.AddFunctionCommand.Execute(newFunction.Type);

            Assert.AreEqual(min, viewModel.CurrentGraph.SelectedFunction.MinLimit);
            Assert.AreEqual(max, viewModel.CurrentGraph.SelectedFunction.MaxLimit);
            Assert.AreEqual(type, viewModel.CurrentGraph.SelectedFunction.Type);
            Assert.AreEqual("y = Cos(x)", viewModel.CurrentGraph.SelectedFunction.Equation);
        }

        [TestMethod]
        public void AddFunctionWithWrongArgument()
        {
            double min = 12;
            double max = -12;
            double a = 10;
            double b = 1;
            double c = 9;
            string type = "y = x^[a]";
            AddFunctionViewModel viewModel = new AddFunctionViewModel();
            IFunction newFunction = new FunctionWithOneCoef(type, min, max, new List<double>() { a, b, c });
            viewModel.MinLimit = min;
            viewModel.MaxLimit = max;
            viewModel.ACoef = a;
            viewModel.BCoef = b;
            viewModel.CCoef = c;

            viewModel.AddFunctionCommand.Execute(newFunction.Type);

            Assert.AreNotEqual(min, viewModel.CurrentGraph.SelectedFunction.MinLimit);
            Assert.AreNotEqual(max, viewModel.CurrentGraph.SelectedFunction.MaxLimit);
            Assert.AreNotEqual(type, viewModel.CurrentGraph.SelectedFunction.Type);
            Assert.AreNotEqual("y = x^10", viewModel.CurrentGraph.SelectedFunction.Equation);
        }
    }
}
