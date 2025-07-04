using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class GraphicsViewModel : IViewModel
    {
        bool messageShown = false;
        private IFunctionCalculator _calculator;
        public ICommand DisplayAddFunctionCommand { get; set; }
        public ICommand IncreaseCommand { get; set; }
        public ICommand DeacreaseCommand { get; set; }

        public GraphicsViewModel(IFunctionCalculator functionCalculator)
        {
            DisplayAddFunctionCommand = new RelayCommand(displayAddFunction);
            IncreaseCommand = new RelayCommand(increaseValue);
            DeacreaseCommand = new RelayCommand(decreaseValue);
            _calculator = functionCalculator;
            CurrentGraph.FunctionChanged += UpdateGraphData;
        }
        

        private void displayAddFunction(object par)
        {

        }

        private void decreaseValue(object par)
        {

        }

        private void increaseValue(object par)
        {

        }

        public ObservableCollection<DataPoint> Points { get; } = new ObservableCollection<DataPoint>();

        public void UpdateGraphData()
        {
            Points.Clear();
            IFunction func = CurrentGraph.SelectedFunction;
            double step = 0.1;

            try
            {
                List<DataPoint> result = RunWithTimeout(() => CalculatePoints(func, step), 2500000);
                result.ForEach((p)  => {Points.Add(p); });
            }
            catch (TimeoutException e)
            {
                MessageNeeded?.Invoke(e.Message);
            }
            catch (OverflowException)
            {
                MessageNeeded?.Invoke("Y превысило допустимое значение");
            }


        }
        

        private List<DataPoint> CalculatePoints(IFunction func, double step)
        {
            List<DataPoint> points = new List<DataPoint>();
            
            for (double x = func.MinLimit; x <= func.MaxLimit; x += step)
            {
                double y = 0;
                try
                {
                    y = _calculator.Calculate(func.Equation, x);
                    if (double.IsNaN(y) && !messageShown) { 
                        MessageNeeded?.Invoke("Недопустимые значения не отображаются");
                        messageShown = true;
                    }
                    points.Add(new DataPoint(x, y));
                }
                catch (OverflowException)
                {
                    y = 0;
                    MessageNeeded?.Invoke("Недопустимые значения не отображаются");
                    break;
                }
                catch (Exception e)
                {
                    y = 0;
                    MessageNeeded?.Invoke(e.Message);
                    break;
                }
            }
            return points;
        }
        
        
       

        public static T RunWithTimeout<T>(Func<T> func, int timeoutMs)
        {
            var task = Task.Run(func);
            if (task.Wait(timeoutMs))
                return task.Result;

            throw new TimeoutException("Вычисления заняли слишком много времени");
        }


        public event MessageHandler MessageNeeded;

    }
}
