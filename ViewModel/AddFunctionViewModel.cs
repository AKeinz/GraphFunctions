using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class AddFunctionViewModel : IViewModel
    {
        public ICommand AddFunctionCommand { get; set; }

        private double aCoef = 1;
        public double ACoef {
            get { return aCoef; }
            set { aCoef = value; OnPropertyChanged(nameof(ACoef)); }
        }

        private double bCoef = 1;
        public double BCoef
        {
            get { return bCoef; }
            set { bCoef = value; OnPropertyChanged(nameof(BCoef)); }
        }

        private double cCoef = 1;
        public double CCoef
        {
            get { return cCoef; }
            set { cCoef = value; OnPropertyChanged(nameof(CCoef)); }
        }

        private double minLimit = -10;
        public double MinLimit
        {
            get { return minLimit; }
            set { minLimit = value; OnPropertyChanged(nameof(MinLimit)); }
        }

        private double maxLimit = 10;
        public double MaxLimit
        {
            get { return maxLimit; }
            set { maxLimit = value; OnPropertyChanged(nameof(MaxLimit)); }
        }

        public Dictionary<string, int> AvailableFunctionsDict { get; set; } = AvailableFunctions.GetAvailableFunctionsDict();

        public AddFunctionViewModel()
        {
            AddFunctionCommand = new RelayCommand(addFunction);
        }


        private void addFunction(object par)
        {
            try
            {
                if (MinLimit >= MaxLimit) { MessageNeeded?.Invoke("Минимальное значение интервала должно быть меньше максимального"); return; }
                string chosenFunc = par.ToString();
                List<double> coefs = new List<double>();
                coefs.Add(ACoef);
                coefs.Add(BCoef);
                coefs.Add(CCoef);
                IFunction newFunction = FunctionFabric.CreateFunction(chosenFunc, coefs, (MinLimit, MaxLimit));
                CurrentGraph.SelectedFunction = newFunction;
            }
            catch(Exception ex) 
            {
                MessageNeeded?.Invoke(ex.Message);
            }

        }


        public event MessageHandler MessageNeeded;
    }
}
