namespace Assignment5_300936445
{
    partial class BMICalculator
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
            this.BMICalculatorLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.BMICalculatorLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculatorLayoutPanel
            // 
            this.BMICalculatorLayoutPanel.ColumnCount = 3;
            this.BMICalculatorLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BMICalculatorLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BMICalculatorLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BMICalculatorLayoutPanel.Controls.Add(this.ImperialRadioButton, 1, 0);
            this.BMICalculatorLayoutPanel.Controls.Add(this.MetricRadioButton, 2, 0);
            this.BMICalculatorLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.BMICalculatorLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
            this.BMICalculatorLayoutPanel.Controls.Add(this.HeightTextBox, 1, 1);
            this.BMICalculatorLayoutPanel.Controls.Add(this.WeightTextBox, 1, 2);
            this.BMICalculatorLayoutPanel.Controls.Add(this.resultTextBox, 1, 3);
            this.BMICalculatorLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 4);
            this.BMICalculatorLayoutPanel.Controls.Add(this.ResetButton, 2, 4);
            this.BMICalculatorLayoutPanel.Controls.Add(this.HeightUnitLabel, 2, 1);
            this.BMICalculatorLayoutPanel.Controls.Add(this.WeightUnitLabel, 2, 2);
            this.BMICalculatorLayoutPanel.Controls.Add(this.ResultLabel, 0, 3);
            this.BMICalculatorLayoutPanel.Location = new System.Drawing.Point(12, 71);
            this.BMICalculatorLayoutPanel.Name = "BMICalculatorLayoutPanel";
            this.BMICalculatorLayoutPanel.RowCount = 5;
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMICalculatorLayoutPanel.Size = new System.Drawing.Size(280, 303);
            this.BMICalculatorLayoutPanel.TabIndex = 0;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(96, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(87, 54);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(189, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(88, 54);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(10, 60);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(80, 60);
            this.HeightLabel.TabIndex = 4;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(7, 120);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(83, 60);
            this.WeightLabel.TabIndex = 5;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightTextBox.Location = new System.Drawing.Point(96, 63);
            this.HeightTextBox.MaxLength = 3;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(87, 38);
            this.HeightTextBox.TabIndex = 6;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightTextBox.Location = new System.Drawing.Point(96, 123);
            this.WeightTextBox.MaxLength = 3;
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(87, 38);
            this.WeightTextBox.TabIndex = 7;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(35, 180);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(55, 60);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.White;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMICalculatorLayoutPanel.SetColumnSpan(this.resultTextBox, 2);
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Location = new System.Drawing.Point(96, 183);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(181, 54);
            this.resultTextBox.TabIndex = 9;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BMICalculatorLayoutPanel.SetColumnSpan(this.CalculateBMIButton, 2);
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 243);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(180, 57);
            this.CalculateBMIButton.TabIndex = 10;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.OrangeRed;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(189, 243);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(88, 57);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Clear";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnitLabel.Location = new System.Drawing.Point(189, 60);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(28, 60);
            this.HeightUnitLabel.TabIndex = 12;
            this.HeightUnitLabel.Text = "FT";
            this.HeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnitLabel.Location = new System.Drawing.Point(189, 120);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(29, 60);
            this.WeightUnitLabel.TabIndex = 13;
            this.WeightUnitLabel.Text = "LB";
            this.WeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMICalculatorLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator App";
            this.BMICalculatorLayoutPanel.ResumeLayout(false);
            this.BMICalculatorLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICalculatorLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
    }
}

