using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Graph : INotifyPropertyChanged
    {
        private static Graph fieldSingletone;

        private IFunction selectedFunction = new FunctionWithouCoef("Функция не выбрана", -10, 10);
        public IFunction SelectedFunction
        {
            get { return selectedFunction; }
            set
            {
                if (selectedFunction != null)
                {
                    selectedFunction.PropertyChanged -= OnSelectedFunctionPropertyChanged;
                }

                selectedFunction = value ?? new FunctionWithouCoef("Функция не выбрана", -10, 10);

                if (selectedFunction != null)
                {
                    selectedFunction.PropertyChanged += OnSelectedFunctionPropertyChanged;
                }

                OnPropertyChanged(nameof(SelectedFunction));
                FunctionChanged?.Invoke();
            }
        }
        

        public static Graph GetGraph()
        {
            if (fieldSingletone == null)
            {
                fieldSingletone = new Graph();
            }
            return fieldSingletone;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnSelectedFunctionPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            FunctionChanged?.Invoke();
        }

        public delegate void EquationHandler();
        public event EquationHandler FunctionChanged;

    }
}
