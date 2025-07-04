using NCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ViewModel
{
    public class NCalcFunctionCalculator : IFunctionCalculator
    {
        public double Calculate(string equation, double x)
        {
            equation = equation.Substring(4);

            equation = Regex.Replace(equation, @"([x0-9_]+)\^([x0-9_]+)", "Pow($1,$2)");
            equation = Regex.Replace(equation, @"Mod\s*\(\s*x\s*,\s*(\d+(\.*\d+)?)\s*\)", "x % $1");
            equation = equation.Replace("ln(x)", "Log(x, E)");
            equation = Regex.Replace(equation, @"ln\(([^)]+)\)", "Log($1), E");
            equation = equation.Replace("Arctg(x)", "Atan(x)");
            equation = equation.Replace("Arcctg(x)", "((PI/2)-Atan(x))");
            equation = equation.Replace("Arccos(x)", "Acos(x)");
            equation = equation.Replace("Arcsin(x)", "Asin(x)");

            try
            {
                var expr = new Expression(equation);
                expr.Parameters["x"] = x;
                expr.Parameters["PI"] = Math.PI;
                expr.Parameters["E"] = Math.E;
                if (Convert.ToDecimal(expr.Evaluate()) >= decimal.MaxValue || Convert.ToDecimal(expr.Evaluate()) <= decimal.MinValue)
                {
                    throw new OverflowException();
                }
                if (Convert.ToDouble(expr.Evaluate()) >= double.MaxValue || Convert.ToDouble(expr.Evaluate()) <= double.MinValue)
                {
                    throw new OverflowException();
                }

                if (equation.Contains("Exp") && (x > 60 || x < -60) )
                {
                    throw new OverflowException();
                }
                else if (equation.Contains("Exp") && equation.Contains("Pow") && (x > 30 || x < -60))
                {
                    throw new OverflowException();
                }

                return Convert.ToDouble(expr.Evaluate());
            }
            catch
            {
                return double.NaN;
            }
        }
    }
}
