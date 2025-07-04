namespace GraphicsForm
{
    partial class AddFunctionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AvailableFunctionsListView = new System.Windows.Forms.ListView();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.CLabel = new System.Windows.Forms.Label();
            this.NewFunctionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxLimitTextBox = new System.Windows.Forms.TextBox();
            this.MinLimitTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.BLabel = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.CLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NewFunctionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.MaxLimitTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.MinLimitTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.BTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.BLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ATextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ALabel);
            this.splitContainer1.Panel2.Controls.Add(this.AddButton);
            this.splitContainer1.Size = new System.Drawing.Size(668, 385);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AvailableFunctionsListView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(319, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функции";
            // 
            // AvailableFunctionsListView
            // 
            this.AvailableFunctionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableFunctionsListView.HideSelection = false;
            this.AvailableFunctionsListView.Location = new System.Drawing.Point(10, 25);
            this.AvailableFunctionsListView.Name = "AvailableFunctionsListView";
            this.AvailableFunctionsListView.Size = new System.Drawing.Size(299, 340);
            this.AvailableFunctionsListView.TabIndex = 0;
            this.AvailableFunctionsListView.UseCompatibleStateImageBehavior = false;
            this.AvailableFunctionsListView.View = System.Windows.Forms.View.List;
            this.AvailableFunctionsListView.SelectedIndexChanged += new System.EventHandler(this.AvailableFunctionsListView_SelectedIndexChanged);
            // 
            // CTextBox
            // 
            this.CTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CTextBox.Location = new System.Drawing.Point(190, 120);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(45, 22);
            this.CTextBox.TabIndex = 24;
            // 
            // CLabel
            // 
            this.CLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(73, 124);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(110, 16);
            this.CLabel.TabIndex = 23;
            this.CLabel.Text = "Коэффициент c";
            // 
            // NewFunctionLabel
            // 
            this.NewFunctionLabel.AutoSize = true;
            this.NewFunctionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewFunctionLabel.Location = new System.Drawing.Point(76, 30);
            this.NewFunctionLabel.Name = "NewFunctionLabel";
            this.NewFunctionLabel.Size = new System.Drawing.Size(0, 25);
            this.NewFunctionLabel.TabIndex = 22;
            this.NewFunctionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "по";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "с";
            // 
            // MaxLimitTextBox
            // 
            this.MaxLimitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxLimitTextBox.Location = new System.Drawing.Point(189, 193);
            this.MaxLimitTextBox.Name = "MaxLimitTextBox";
            this.MaxLimitTextBox.Size = new System.Drawing.Size(46, 22);
            this.MaxLimitTextBox.TabIndex = 19;
            // 
            // MinLimitTextBox
            // 
            this.MinLimitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinLimitTextBox.Location = new System.Drawing.Point(93, 193);
            this.MinLimitTextBox.Name = "MinLimitTextBox";
            this.MinLimitTextBox.Size = new System.Drawing.Size(46, 22);
            this.MinLimitTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Интервал построения функции";
            // 
            // BTextBox
            // 
            this.BTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTextBox.Location = new System.Drawing.Point(190, 92);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(45, 22);
            this.BTextBox.TabIndex = 16;
            // 
            // BLabel
            // 
            this.BLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(73, 96);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(111, 16);
            this.BLabel.TabIndex = 15;
            this.BLabel.Text = "Коэффициент b";
            // 
            // ATextBox
            // 
            this.ATextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ATextBox.Location = new System.Drawing.Point(190, 64);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(45, 22);
            this.ATextBox.TabIndex = 14;
            // 
            // ALabel
            // 
            this.ALabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(73, 68);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(111, 16);
            this.ALabel.TabIndex = 13;
            this.ALabel.Text = "Коэффициент a";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(76, 323);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(197, 50);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Построить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // AddFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 385);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(686, 432);
            this.MinimumSize = new System.Drawing.Size(686, 432);
            this.Name = "AddFunctionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор функции";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView AvailableFunctionsListView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxLimitTextBox;
        private System.Windows.Forms.TextBox MinLimitTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label NewFunctionLabel;
        private System.Windows.Forms.TextBox CTextBox;
        private System.Windows.Forms.Label CLabel;
    }
}