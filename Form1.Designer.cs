namespace wage_calculator
{
    partial class WageCalcMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AnnualWageInput = new Label();
            AnnualWage = new TextBox();
            AnnualWageRadioBtn = new RadioButton();
            WageInputBox = new TextBox();
            label1 = new Label();
            MonthlyWageRadioBtn = new RadioButton();
            WeeklyWageRadioBtn = new RadioButton();
            HourlyWageRadioBtn = new RadioButton();
            MonthlyWage = new TextBox();
            label2 = new Label();
            WeeklyWage = new TextBox();
            label3 = new Label();
            HourlyWage = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // AnnualWageInput
            // 
            AnnualWageInput.AutoSize = true;
            AnnualWageInput.Location = new Point(165, 14);
            AnnualWageInput.Name = "AnnualWageInput";
            AnnualWageInput.Size = new Size(78, 15);
            AnnualWageInput.TabIndex = 0;
            AnnualWageInput.Text = "Annual Wage";
            // 
            // AnnualWage
            // 
            AnnualWage.Location = new Point(165, 32);
            AnnualWage.Name = "AnnualWage";
            AnnualWage.ReadOnly = true;
            AnnualWage.Size = new Size(116, 23);
            AnnualWage.TabIndex = 6;
            // 
            // AnnualWageRadioBtn
            // 
            AnnualWageRadioBtn.AutoSize = true;
            AnnualWageRadioBtn.Location = new Point(41, 73);
            AnnualWageRadioBtn.Name = "AnnualWageRadioBtn";
            AnnualWageRadioBtn.Size = new Size(72, 19);
            AnnualWageRadioBtn.TabIndex = 2;
            AnnualWageRadioBtn.TabStop = true;
            AnnualWageRadioBtn.Text = "Annually";
            AnnualWageRadioBtn.UseVisualStyleBackColor = true;
            // 
            // WageInputBox
            // 
            WageInputBox.Location = new Point(24, 32);
            WageInputBox.Name = "WageInputBox";
            WageInputBox.Size = new Size(116, 23);
            WageInputBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Wage";
            // 
            // MonthlyWageRadioBtn
            // 
            MonthlyWageRadioBtn.AutoSize = true;
            MonthlyWageRadioBtn.Location = new Point(41, 109);
            MonthlyWageRadioBtn.Name = "MonthlyWageRadioBtn";
            MonthlyWageRadioBtn.Size = new Size(70, 19);
            MonthlyWageRadioBtn.TabIndex = 3;
            MonthlyWageRadioBtn.TabStop = true;
            MonthlyWageRadioBtn.Text = "Monthly";
            MonthlyWageRadioBtn.UseVisualStyleBackColor = true;
            // 
            // WeeklyWageRadioBtn
            // 
            WeeklyWageRadioBtn.AutoSize = true;
            WeeklyWageRadioBtn.Location = new Point(41, 145);
            WeeklyWageRadioBtn.Name = "WeeklyWageRadioBtn";
            WeeklyWageRadioBtn.Size = new Size(63, 19);
            WeeklyWageRadioBtn.TabIndex = 4;
            WeeklyWageRadioBtn.TabStop = true;
            WeeklyWageRadioBtn.Text = "Weekly";
            WeeklyWageRadioBtn.UseVisualStyleBackColor = true;
            // 
            // HourlyWageRadioBtn
            // 
            HourlyWageRadioBtn.AutoSize = true;
            HourlyWageRadioBtn.Location = new Point(41, 181);
            HourlyWageRadioBtn.Name = "HourlyWageRadioBtn";
            HourlyWageRadioBtn.Size = new Size(61, 19);
            HourlyWageRadioBtn.TabIndex = 5;
            HourlyWageRadioBtn.TabStop = true;
            HourlyWageRadioBtn.Text = "Hourly";
            HourlyWageRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MonthlyWage
            // 
            MonthlyWage.Location = new Point(165, 82);
            MonthlyWage.Name = "MonthlyWage";
            MonthlyWage.ReadOnly = true;
            MonthlyWage.Size = new Size(116, 23);
            MonthlyWage.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 64);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 8;
            label2.Text = "Monthly Wage";
            // 
            // WeeklyWage
            // 
            WeeklyWage.Location = new Point(165, 132);
            WeeklyWage.Name = "WeeklyWage";
            WeeklyWage.ReadOnly = true;
            WeeklyWage.Size = new Size(116, 23);
            WeeklyWage.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 114);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 10;
            label3.Text = "Weekly Wage";
            // 
            // HourlyWage
            // 
            HourlyWage.Location = new Point(165, 183);
            HourlyWage.Name = "HourlyWage";
            HourlyWage.ReadOnly = true;
            HourlyWage.Size = new Size(116, 23);
            HourlyWage.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 165);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 12;
            label4.Text = "Hourly Wage";
            // 
            // WageCalcMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 221);
            Controls.Add(HourlyWage);
            Controls.Add(label4);
            Controls.Add(WeeklyWage);
            Controls.Add(label3);
            Controls.Add(MonthlyWage);
            Controls.Add(label2);
            Controls.Add(HourlyWageRadioBtn);
            Controls.Add(WeeklyWageRadioBtn);
            Controls.Add(MonthlyWageRadioBtn);
            Controls.Add(label1);
            Controls.Add(WageInputBox);
            Controls.Add(AnnualWageRadioBtn);
            Controls.Add(AnnualWage);
            Controls.Add(AnnualWageInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WageCalcMainWindow";
            ShowIcon = false;
            Text = "Wage Calculator";
            Load += WageCalcMainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AnnualWageInput;
        private TextBox AnnualWage;
        private RadioButton AnnualWageRadioBtn;
        private TextBox WageInputBox;
        private Label label1;
        private RadioButton MonthlyWageRadioBtn;
        private RadioButton WeeklyWageRadioBtn;
        private RadioButton HourlyWageRadioBtn;
        private TextBox MonthlyWage;
        private Label label2;
        private TextBox WeeklyWage;
        private Label label3;
        private TextBox HourlyWage;
        private Label label4;
    }
}
