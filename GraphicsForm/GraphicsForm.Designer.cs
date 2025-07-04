namespace GraphicsForm
{
    partial class GraphicsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AddButton = new System.Windows.Forms.Button();
            this.HintLabel = new System.Windows.Forms.Label();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.CLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxLimitTextBox = new System.Windows.Forms.TextBox();
            this.MinLimitTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.BLabel = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectedFunctionLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.graphicsViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.StatusLabel);
            this.splitContainer1.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AddButton);
            this.splitContainer1.Panel2.Controls.Add(this.HintLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.CLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.MaxLimitTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.MinLimitTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.BTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.BLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ATextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ALabel);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1261, 594);
            this.splitContainer1.SplitterDistance = 904;
            this.splitContainer1.TabIndex = 0;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(10, 0);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(10);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(10);
            this.StatusLabel.Size = new System.Drawing.Size(20, 36);
            this.StatusLabel.TabIndex = 15;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(904, 594);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(82, 527);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(201, 55);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Выбрать функцию";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HintLabel
            // 
            this.HintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(308, 4);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(14, 16);
            this.HintLabel.TabIndex = 15;
            this.HintLabel.Text = "?";
            // 
            // CTextBox
            // 
            this.CTextBox.Location = new System.Drawing.Point(141, 285);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(61, 22);
            this.CTextBox.TabIndex = 14;
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(24, 289);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(110, 16);
            this.CLabel.TabIndex = 13;
            this.CLabel.Text = "Коэффициент c";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "с";
            // 
            // MaxLimitTextBox
            // 
            this.MaxLimitTextBox.Location = new System.Drawing.Point(140, 358);
            this.MaxLimitTextBox.Name = "MaxLimitTextBox";
            this.MaxLimitTextBox.Size = new System.Drawing.Size(61, 22);
            this.MaxLimitTextBox.TabIndex = 10;
            // 
            // MinLimitTextBox
            // 
            this.MinLimitTextBox.Location = new System.Drawing.Point(44, 358);
            this.MinLimitTextBox.Name = "MinLimitTextBox";
            this.MinLimitTextBox.Size = new System.Drawing.Size(61, 22);
            this.MinLimitTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Интервал построения функции";
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(141, 257);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(61, 22);
            this.BTextBox.TabIndex = 6;
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(24, 261);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(111, 16);
            this.BLabel.TabIndex = 5;
            this.BLabel.Text = "Коэффициент b";
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(141, 229);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(61, 22);
            this.ATextBox.TabIndex = 4;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(24, 233);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(111, 16);
            this.ALabel.TabIndex = 3;
            this.ALabel.Text = "Коэффициент a";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SelectedFunctionLabel);
            this.groupBox1.Location = new System.Drawing.Point(21, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уравнение выбранной функции:";
            // 
            // SelectedFunctionLabel
            // 
            this.SelectedFunctionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedFunctionLabel.AutoSize = true;
            this.SelectedFunctionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedFunctionLabel.Location = new System.Drawing.Point(39, 76);
            this.SelectedFunctionLabel.Name = "SelectedFunctionLabel";
            this.SelectedFunctionLabel.Size = new System.Drawing.Size(0, 29);
            this.SelectedFunctionLabel.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "Инструкция";
            // 
            // graphicsViewModelBindingSource
            // 
            this.graphicsViewModelBindingSource.DataSource = typeof(ViewModel.GraphicsViewModel);
            // 
            // GraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 594);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1270, 640);
            this.Name = "GraphicsForm";
            this.Text = "Построение графиков функций";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxLimitTextBox;
        private System.Windows.Forms.TextBox MinLimitTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CTextBox;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label SelectedFunctionLabel;
        private System.Windows.Forms.BindingSource graphicsViewModelBindingSource;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label HintLabel;

    }
}

