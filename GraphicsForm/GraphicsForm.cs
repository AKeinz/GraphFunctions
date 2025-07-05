using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ViewModel;


namespace GraphicsForm
{
    public partial class GraphicsForm : Form
    {
        GraphicsViewModel logic;
        private List<TextBox> textBoxes = new List<TextBox>();


        public GraphicsForm()
        {
            InitializeComponent();

            logic = new GraphicsViewModel(new NCalcFunctionCalculator(), new ExportDataToExcelByClosedXML());

            InitializeTooltips();
            InitializeChart();
            SetupDataBindings();
            InitializeEventHandlers();
        }

        private void InitializeTooltips()
        {
            toolTip1.SetToolTip(HintLabel, "Для создания графика функции нажмите на \"Выбрать функцию\"\n\n" +
                "Для перемещения между коэффициентами и пределами интервала построения\n используйте клавиши вверх-вниз.\n\n" +
                "Для увеличения-уменьшения значения параметра\n используйте клавиши вправо-влево\n\n" +
                "При наведении на график отображаются\n координаты точки во всплывающем окне\n\n" +
                "При экспорте создается таблица Excel со значениями текущей функции в папке Documents\\MyExports");
        }

        private void InitializeChart()
        {
            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Title = "Ось X";
            chartArea.AxisY.Title = "Ось Y";
            chart1.Titles.Add("График функции");

            ConfigureChartAxis(chartArea.AxisX);
            ConfigureChartAxis(chartArea.AxisY);

            InitializeChartSeries();
        }

        private void ConfigureChartAxis(Axis axis)
        {
            axis.MajorGrid.LineColor = Color.LightGray;
            axis.IntervalAutoMode = IntervalAutoMode.FixedCount;
            axis.Crossing = 0;
            axis.ArrowStyle = AxisArrowStyle.Triangle;
        }

        private void InitializeChartSeries()
        {
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series[0].Color = Color.Green;

            chart1.Series.Add(new Series
            {
                ChartType = SeriesChartType.Line,
                IsVisibleInLegend = false,
                Color = Color.Orange
            });
        }

        private void SetupDataBindings()
        {
            SelectedFunctionLabel.DataBindings.Add(
                new Binding("Text", logic.CurrentGraph, "SelectedFunction.Equation", true,
                    DataSourceUpdateMode.OnPropertyChanged)
                );

            MinLimitTextBox.DataBindings.Add(new Binding("Text", logic.CurrentGraph, "SelectedFunction.MinLimit",
                true, DataSourceUpdateMode.OnPropertyChanged));
            MaxLimitTextBox.DataBindings.Add(new Binding("Text", logic.CurrentGraph, "SelectedFunction.MaxLimit",
                true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void InitializeEventHandlers()
        {
            ExportButton.Click += (sender, e) =>
            {
                logic.ExportToExcelCommand.Execute(sender);
            };

            logic.PointsFirstBranch.CollectionChanged += (s, e) => UpdateChart();
            logic.PointsSecondBranch.CollectionChanged += (s, e) => UpdateChartSecondBranch();

            InitializeTextBoxes();


            chart1.GetToolTipText += (sender, e) =>
            {
                if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
                {
                    var point = chart1.Series[0].Points[e.HitTestResult.PointIndex];
                    e.Text = $"X: {point.XValue:F2}\nY: {point.YValues[0]:F2}";
                }
            };

            logic.MessageNeeded += ShowMesage;
        }

        private void InitializeTextBoxes()
        {
            textBoxes.AddRange(new[] { ATextBox, BTextBox, CTextBox, MinLimitTextBox, MaxLimitTextBox });
            textBoxes.ForEach(tb => tb.KeyDown += TextBox_KeyDown);
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            AddFunctionForm addFunctionForm = new AddFunctionForm();
            addFunctionForm.ShowDialog();

            ResetCoefficientControls();

            if (AvailableFunctions.GetAvailableFunctionsDict().ContainsKey(logic.CurrentGraph.SelectedFunction.Type))
            {
                int countOfCoefs = AvailableFunctions.GetAvailableFunctionsDict()[logic.CurrentGraph.SelectedFunction.Type];

                if (countOfCoefs >= 1)
                {
                    ALabel.Visible = true;
                    ATextBox.Visible = true;
                    ATextBox.DataBindings.Add(new Binding("Text", logic.CurrentGraph, "SelectedFunction.ACoef",
                    true, DataSourceUpdateMode.OnPropertyChanged));
                }
                if (countOfCoefs >= 2)
                {
                    BLabel.Visible = true;
                    BTextBox.Visible = true;
                    BTextBox.DataBindings.Add(new Binding("Text", logic.CurrentGraph, "SelectedFunction.BCoef",
                    true, DataSourceUpdateMode.OnPropertyChanged));
                }
                if (countOfCoefs >= 3)
                {
                    CLabel.Visible = true;
                    CTextBox.Visible = true;
                    CTextBox.DataBindings.Add(new Binding("Text", logic.CurrentGraph, "SelectedFunction.CCoef",
                    true, DataSourceUpdateMode.OnPropertyChanged));
                }
            }
        }

        private void ResetCoefficientControls()
        {
            ALabel.Visible = BLabel.Visible = CLabel.Visible = false;
            ATextBox.Visible = BTextBox.Visible = CTextBox.Visible = false;

            ATextBox.DataBindings.Clear();
            BTextBox.DataBindings.Clear();
            CTextBox.DataBindings.Clear();
        }


        private void UpdateChart()
        {
            chart1.Series[0].Points.Clear();


            foreach (var point in logic.PointsFirstBranch)
            {
                chart1.Series[0].Points.AddXY(point.X, point.Y);
            }

            chart1.ChartAreas[0].AxisX.RoundAxisValues();


        }

        private void UpdateChartSecondBranch()
        {
            chart1.Series[1].Points.Clear();


            foreach (var point in logic.PointsSecondBranch)
            {
                chart1.Series[1].Points.AddXY(point.X, point.Y);
            }

            chart1.ChartAreas[0].AxisX.RoundAxisValues();
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            var currentTextBox = sender as TextBox;
            int currentIndex = textBoxes.IndexOf(currentTextBox);

            switch (e.KeyCode)
            {
                case Keys.Down:
                    while (true)
                    {
                        if (currentIndex == textBoxes.Count - 1)
                        {
                            currentIndex = -1;
                        }
                        if (textBoxes[currentIndex+1].Visible)
                        {
                            textBoxes[currentIndex + 1].Focus();
                            e.Handled = true;
                            break;
                        }
                        else { currentIndex++; }
                    }
                    break;

                case Keys.Up:
                    while (true)
                    {
                        if (currentIndex == 0)
                        {
                            currentIndex = textBoxes.Count;
                        }
                        if (textBoxes[currentIndex - 1].Visible)
                        {
                            textBoxes[currentIndex - 1].Focus();
                            e.Handled = true;
                            break;
                        }
                        else { currentIndex--; }
                    }
                    break;

                case Keys.Right:
                    //logic.IncreaseCommand.Execute();
                    double.TryParse(textBoxes[currentIndex].Text, out double result);
                    textBoxes[currentIndex].Text = (result +1).ToString();
                    break;

                case Keys.Left:
                    //logic.DeacreaseCommand.Execute();
                    double.TryParse(textBoxes[currentIndex].Text, out double result1);
                    textBoxes[currentIndex].Text = (result1 - 1).ToString();
                    break;

            }
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            var area = chart1.ChartAreas[0];

            double x = area.AxisX.PixelPositionToValue(e.Location.X);
            double y = area.AxisY.PixelPositionToValue(e.Location.Y);

            StatusLabel.Text = $"Текущие координаты\nX: {x:F2}, Y: {y:F2}";
        }

        private void ShowMesage(string message)
        {
            MessageBox.Show(message);
        }
        
    }
}
