using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FunctionWithouCoef : IFunction
    {
        public FunctionWithouCoef(string type, double minLimit, double maxLimit) 
        { 
            this.Type = type;
            this.MinLimit = minLimit;
            this.MaxLimit = maxLimit;
            this.Equation = type;
        }
    }
}
