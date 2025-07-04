using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class IFunction : INotifyPropertyChanged
    {
        private const double AbsoluteMinLimit = -100;
        private const double AbsoluteMaxLimit = 100;

        private string type = "Функция не выбрана";

        public string Type
        {
            get { return type; }
            set { type = value; OnPropertyChanged(nameof(Type)); }
        }

        private string equation = "Функция не выбрана";

        public string Equation
        {
            get { return equation; }
            set { equation = value;  }
        }

        private double minLimit = -10;
        public double MinLimit
        {
            get { return minLimit; }
            set {
                if (value < AbsoluteMinLimit )
                {
                    value = AbsoluteMinLimit;
                }
                else if (value > AbsoluteMaxLimit)
                {
                    value = AbsoluteMaxLimit;
                }
                minLimit = value;
                OnPropertyChanged(nameof(MinLimit));
            }
        }

        private double maxLimit = 10;

        public double MaxLimit
        {
            get { return maxLimit; }
            set
            {
                if (value < AbsoluteMinLimit)
                {
                    value = AbsoluteMinLimit;
                }
                else if (value > AbsoluteMaxLimit)
                {
                    value = AbsoluteMaxLimit;
                }
                maxLimit = value;
                OnPropertyChanged(nameof(MaxLimit));
            }
        }


        public virtual void UpdateEquation() { }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



    }
}
