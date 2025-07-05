using System.Collections.Generic;

namespace Model
{
    public class FunctionWithTwoCoef : IFunction
    {
        private double aCoef = 1;

        public double ACoef
        {
            get { return aCoef; }
            set { aCoef = value; OnPropertyChanged(nameof(ACoef)); UpdateEquation(); }
        }

        private double bCoef = 1;

        public double BCoef
        {
            get { return bCoef; }
            set { bCoef = value; OnPropertyChanged(nameof(BCoef)); UpdateEquation(); }
        }

        public override void UpdateEquation()
        {
            Equation = Type.Replace("[a]", ACoef.ToString())
                .Replace("[b]", BCoef.ToString());

        }


        public FunctionWithTwoCoef(string type, double minLimit, double maxLimit, List<double> coefs)
        {
            this.Type = type;
            this.MinLimit = minLimit;
            this.MaxLimit = maxLimit;
            this.ACoef = coefs[0];
            this.BCoef = coefs[1];
        }

    }
}
