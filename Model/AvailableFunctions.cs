using System.Collections.Generic;

namespace Model
{
    public static class AvailableFunctions
    {
        private static readonly Dictionary<string, int> availableFunctions = new Dictionary<string, int>()
        {
            // уравнение, кол-во коэффициентов
            {"y = Mod(x,[a])", 1 },
            {"y = x^3", 0 },
            {"y = [a]*x^3", 1 },
            {"y = Cos(x)", 0 },
            {"y = Sqrt(x)", 0 },

            {"y = x^[a]", 1 },
            {"y = ln(x)",0 },
            {"y = Arcsin(x)", 0 },
            {"y = Arccos(x)", 0 },
            {"y = Arctg(x)", 0 },

            {"y = Arcctg(x)", 0 },
            {"y = Log(x,[a])", 1 },
            {"y = 1/x", 0 },
            {"y = ln(Cos(x))", 0 }, 
            {"y = Sqrt(Arctg(x))", 0 }, 

            {"y = ln(Sin(x))", 0 }, 
            {"y = Pow(Exp(x),2)", 0 },  
            {"y = Exp(x)", 0 },
            {"y = [a]*x^2+[b]*x+[c]", 3 },
            {"y = [a]*Sin(x*[b])+[c]", 3 },

            {"y = [a]*x+[b]", 2 },
            {"y = [a]*x^3+[b]*x^2", 2 },
            {"y = [a]/x + [b]*x", 2 },
            {"y = Sin(x)*Cos(x)", 0 },
        };
        public static Dictionary<string, int> GetAvailableFunctionsDict() { return availableFunctions; }

        public static List<string> GetAvailableFunctionsList() 
        {
            List<string> funcs = new List<string>();
            foreach(string func in availableFunctions.Keys)
            {
                funcs.Add(func);
            }
            return funcs;
        }
    }
}
