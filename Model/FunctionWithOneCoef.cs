using System.Collections.Generic;

namespace Model
{
    public class FunctionWithOneCoef : IFunction
    {
        private double aCoef = 1;

        public double ACoef
        {
            get { return aCoef; }
            set { aCoef = value; OnPropertyChanged(nameof(ACoef)); UpdateEquation(); }
        }

        public override void UpdateEquation()
        {
            Equation = Type.Replace("[a]", ACoef.ToString());
        }


        public FunctionWithOneCoef(string type, double minLimit, double maxLimit, List<double> coefs)
        {
            this.Type = type;
            this.MinLimit = minLimit;
            this.MaxLimit = maxLimit;
            this.ACoef = coefs[0];
        }

    }
}
