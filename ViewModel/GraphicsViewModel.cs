using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class GraphicsViewModel : IViewModel
    {
        private IExportDataToExcel exportDataToExcel;
        private IFunctionCalculator _calculator;

        bool messageShown = false;
        public ICommand ExportToExcelCommand { get; set; }
        public ObservableCollection<DataPoint> PointsFirstBranch { get; } = new ObservableCollection<DataPoint>();
        public ObservableCollection<DataPoint> PointsSecondBranch { get; } = new ObservableCollection<DataPoint>();

        public GraphicsViewModel(IFunctionCalculator functionCalculator, IExportDataToExcel exportDataToExcel)
        {
            ExportToExcelCommand = new RelayCommand(exportToExcel);

            _calculator = functionCalculator;
            this.exportDataToExcel = exportDataToExcel;

            CurrentGraph.FunctionChanged += UpdateGraphData;
        }
        

        private void exportToExcel(object par)
        {
            try
            {
                if (PointsFirstBranch.Count == 0) { return; }
                List<DataPoint> points = new List<DataPoint>();
                points.AddRange(PointsFirstBranch);
                points.AddRange(PointsSecondBranch);
                string fileName = exportDataToExcel.ExportDataToExcel(CurrentGraph.SelectedFunction.Equation, points);
                if (!String.IsNullOrEmpty(fileName)) { Process.Start(new ProcessStartInfo(fileName) { UseShellExecute = true }); }
                else { MessageNeeded?.Invoke("Не удалось экспортировать"); }
            }
            catch (Exception e)
            {
                MessageNeeded?.Invoke($"Ошибка: {e.Message}");
            }
        }

        

        public void UpdateGraphData()
        {
            ClearPoints();
            IFunction func = CurrentGraph.SelectedFunction;
            double step = 0.1;

            try
            {
                List<DataPoint> result = RunWithTimeout(() => CalculatePoints(func, step), 2500);
                if (func.Type.Contains("/x"))
                {
                    int index = 0;
                    foreach (DataPoint point in result)
                    {
                        if (point.X > -0.1 || Math.Abs(point.Y) < double.Epsilon) { index = result.IndexOf(point); break; }
                        PointsFirstBranch.Add(point);
                    }
                    for (int i = index; i < result.Count-2; i++)
                    {
                        if (result[i].X < 0.1 || Math.Abs(result[i].Y) < double.Epsilon) { continue; }
                        PointsSecondBranch.Add(result[i]);
                    }
                }
                else
                {
                    result.ForEach((p) => { PointsFirstBranch.Add(p); });
                }

           }
            catch (TimeoutException e)
            {
                MessageNeeded?.Invoke(e.Message);
            }
            catch (OverflowException)
            {
                MessageNeeded?.Invoke("Y превысило допустимое значение");
            }
            catch (Exception ex)
            {
                MessageNeeded?.Invoke($"Ошибка: {ex.Message}");
            }
        }

        private void ClearPoints()
        {
            PointsFirstBranch.Clear();
            PointsSecondBranch.Clear();
        }


        private List<DataPoint> CalculatePoints(IFunction func, double step)
        {
            List<DataPoint> points = new List<DataPoint>();
            
            for (double x = func.MinLimit; x <= func.MaxLimit; x += step)
            {
                x = Math.Round(x, 1);
                double y = 0;
                try
                {
                    y = Math.Round(_calculator.Calculate(func.Equation, x),4);
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
