using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public interface IFunctionCalculator
    {
        double Calculate(string equation, double x);
    }
}
