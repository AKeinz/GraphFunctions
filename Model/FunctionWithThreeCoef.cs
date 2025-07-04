using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FunctionWithThreeCoef : IFunction
    {
        private double aCoef = 1;

        public double ACoef
        {
            get { return aCoef; }
            set
            {
                if (value < double.MinValue)
                {
                    value = double.MinValue;
                }
                else if (value > double.MaxValue)
                {
                    value = double.MaxValue;
                }
                aCoef = value;
                OnPropertyChanged(nameof(ACoef));
                UpdateEquation();
            }
        }

        private double bCoef = 1;

        public double BCoef
        {
            get { return bCoef; }
            set { bCoef = value; OnPropertyChanged(nameof(BCoef)); UpdateEquation(); }
        }

        private double cCoef = 1;
        public double CCoef
        {
            get { return cCoef; }
            set {cCoef = value; OnPropertyChanged(nameof(CCoef)); UpdateEquation(); }
        }

        public override void UpdateEquation()
        {
            Equation = Type.Replace("[a]", ACoef.ToString())
                .Replace("[b]", BCoef.ToString())
                .Replace("[c]", CCoef.ToString());
        }


        public FunctionWithThreeCoef(string type, double minLimit, double maxLimit, List<double> coefs)
        {
            this.Type = type;
            this.MinLimit = minLimit;
            this.MaxLimit = maxLimit;
            this.ACoef = coefs[0];
            this.BCoef = coefs[1];
            this.CCoef = coefs[2];
        }


    }
}
