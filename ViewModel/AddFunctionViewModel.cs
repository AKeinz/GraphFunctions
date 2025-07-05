using Model;
using System;
using System.Collections.Generic;
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
                ValidateLimits();
                IFunction newFunction = CreateFunction(par.ToString());
                CurrentGraph.SelectedFunction = newFunction;
            }
            catch(Exception ex) 
            {
                MessageNeeded?.Invoke(ex.Message);
            }

        }

        private void ValidateLimits()
        {
            if (MinLimit >= MaxLimit)
                throw new ArgumentException("Минимальное значение интервала должно быть меньше максимального");
        }

        private IFunction CreateFunction(string chosenFunc)
        {
            var coefs = new List<double> { ACoef, BCoef, CCoef };
            return FunctionFactory.FunctionFactory.CreateFunction(chosenFunc, coefs, (MinLimit, MaxLimit));
        }


        public event MessageHandler MessageNeeded;
    }
}
