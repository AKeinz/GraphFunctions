using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel;

namespace GraphicsForm
{
    public partial class AddFunctionForm : Form
    {
        private List<TextBox> textBoxes = new List<TextBox>();
        public AddFunctionForm()
        {
            AddFunctionViewModel logic = new AddFunctionViewModel();
            InitializeComponent();
            foreach (string func in logic.AvailableFunctionsDict.Keys)
            {
                AvailableFunctionsListView.Items.Add(func);
            }
            AddButton.Click += (sender, e) =>
            {
                if (AvailableFunctionsListView.SelectedIndices.Count > 0) {
                    logic.AddFunctionCommand.Execute(AvailableFunctionsListView.SelectedItems[0].Text);
                    Close(); }
            };

            logic.MessageNeeded += ShowMessage;

            ATextBox.DataBindings.Add(new Binding("Text", logic, "ACoef"));
            BTextBox.DataBindings.Add(new Binding("Text", logic, "BCoef"));
            CTextBox.DataBindings.Add(new Binding("Text", logic, "CCoef"));
            MinLimitTextBox.DataBindings.Add(new Binding("Text", logic, "MinLimit"));
            MaxLimitTextBox.DataBindings.Add(new Binding("Text", logic, "MaxLimit"));

            textBoxes.Add(ATextBox);
            textBoxes.Add(BTextBox);
            textBoxes.Add(CTextBox);
            textBoxes.Add(MinLimitTextBox);
            textBoxes.Add(MaxLimitTextBox);

            foreach (var tb in textBoxes)
            {
                tb.KeyDown += TextBox_KeyDown;
            }
        }

        private void AvailableFunctionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailableFunctionsListView.SelectedIndices.Count > 0)
            {
                NewFunctionLabel.Text = AvailableFunctionsListView.SelectedItems[0].Text;
                ALabel.Visible = false;
                BLabel.Visible = false;
                ATextBox.Visible = false;
                BTextBox.Visible = false;
                CLabel.Visible = false;
                CTextBox.Visible = false;
                string chosenFunc = AvailableFunctionsListView.SelectedItems[0].Text;
                int countOfCoefs = AvailableFunctions.GetAvailableFunctionsDict()[chosenFunc];
                if (countOfCoefs >= 1)
                {
                    ALabel.Visible = true;
                    ATextBox.Visible = true;
                }
                if (countOfCoefs >= 2)
                {
                    BLabel.Visible = true;
                    BTextBox.Visible = true;
                }
                if (countOfCoefs >= 3)
                {
                    CLabel.Visible = true;
                    CTextBox.Visible = true;
                }
            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
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
                        if (textBoxes[currentIndex + 1].Visible)
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
                    textBoxes[currentIndex].Text = (result + 1).ToString();
                    break;

                case Keys.Left:
                    //logic.DeacreaseCommand.Execute();
                    double.TryParse(textBoxes[currentIndex].Text, out double result1);
                    textBoxes[currentIndex].Text = (result1 - 1).ToString();
                    break;

            }
        }
    }
}
