namespace pomodoro_timer
{
    partial class FormSettings
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
            ButtonSave = new Button();
            ButtonCancel = new Button();
            LabelWorkTime = new Label();
            LabelRestTime = new Label();
            LabelLongRestTime = new Label();
            TextBoxWorkTime = new TextBox();
            TextBoxRestTime = new TextBox();
            TextBoxLongRestTime = new TextBox();
            LabelWorkTimeMin = new Label();
            LabelRestTimeMin = new Label();
            LabelLongRestTimeMin = new Label();
            SuspendLayout();
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(281, 227);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(161, 48);
            ButtonSave.TabIndex = 0;
            ButtonSave.Text = "保存";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(485, 227);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(161, 48);
            ButtonCancel.TabIndex = 1;
            ButtonCancel.Text = "キャンセル";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // LabelWorkTime
            // 
            LabelWorkTime.AutoSize = true;
            LabelWorkTime.Location = new Point(148, 79);
            LabelWorkTime.Name = "LabelWorkTime";
            LabelWorkTime.Size = new Size(69, 20);
            LabelWorkTime.TabIndex = 2;
            LabelWorkTime.Text = "作業時間";
            // 
            // LabelRestTime
            // 
            LabelRestTime.AutoSize = true;
            LabelRestTime.Location = new Point(373, 79);
            LabelRestTime.Name = "LabelRestTime";
            LabelRestTime.Size = new Size(69, 20);
            LabelRestTime.TabIndex = 3;
            LabelRestTime.Text = "休憩時間";
            // 
            // LabelLongRestTime
            // 
            LabelLongRestTime.AutoSize = true;
            LabelLongRestTime.Location = new Point(550, 79);
            LabelLongRestTime.Name = "LabelLongRestTime";
            LabelLongRestTime.Size = new Size(96, 20);
            LabelLongRestTime.TabIndex = 4;
            LabelLongRestTime.Text = "長い休憩時間";
            LabelLongRestTime.Click += LabelLongRestTime_Click;
            // 
            // TextBoxWorkTime
            // 
            TextBoxWorkTime.Location = new Point(87, 133);
            TextBoxWorkTime.Name = "TextBoxWorkTime";
            TextBoxWorkTime.Size = new Size(100, 27);
            TextBoxWorkTime.TabIndex = 5;
            // 
            // TextBoxRestTime
            // 
            TextBoxRestTime.Location = new Point(312, 133);
            TextBoxRestTime.Name = "TextBoxRestTime";
            TextBoxRestTime.Size = new Size(100, 27);
            TextBoxRestTime.TabIndex = 6;
            // 
            // TextBoxLongRestTime
            // 
            TextBoxLongRestTime.Location = new Point(516, 133);
            TextBoxLongRestTime.Name = "TextBoxLongRestTime";
            TextBoxLongRestTime.Size = new Size(100, 27);
            TextBoxLongRestTime.TabIndex = 7;
            // 
            // LabelWorkTimeMin
            // 
            LabelWorkTimeMin.AutoSize = true;
            LabelWorkTimeMin.Location = new Point(193, 136);
            LabelWorkTimeMin.Name = "LabelWorkTimeMin";
            LabelWorkTimeMin.Size = new Size(24, 20);
            LabelWorkTimeMin.TabIndex = 8;
            LabelWorkTimeMin.Text = "分";
            // 
            // LabelRestTimeMin
            // 
            LabelRestTimeMin.AutoSize = true;
            LabelRestTimeMin.Location = new Point(418, 136);
            LabelRestTimeMin.Name = "LabelRestTimeMin";
            LabelRestTimeMin.Size = new Size(24, 20);
            LabelRestTimeMin.TabIndex = 9;
            LabelRestTimeMin.Text = "分";
            // 
            // LabelLongRestTimeMin
            // 
            LabelLongRestTimeMin.AutoSize = true;
            LabelLongRestTimeMin.Location = new Point(622, 136);
            LabelLongRestTimeMin.Name = "LabelLongRestTimeMin";
            LabelLongRestTimeMin.Size = new Size(24, 20);
            LabelLongRestTimeMin.TabIndex = 10;
            LabelLongRestTimeMin.Text = "分";
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 316);
            Controls.Add(LabelLongRestTimeMin);
            Controls.Add(LabelRestTimeMin);
            Controls.Add(LabelWorkTimeMin);
            Controls.Add(TextBoxLongRestTime);
            Controls.Add(TextBoxRestTime);
            Controls.Add(TextBoxWorkTime);
            Controls.Add(LabelLongRestTime);
            Controls.Add(LabelRestTime);
            Controls.Add(LabelWorkTime);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Name = "FormSettings";
            Text = "FormSettings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonSave;
        private Button ButtonCancel;
        private Label LabelWorkTime;
        private Label LabelRestTime;
        private Label LabelLongRestTime;
        private TextBox TextBoxWorkTime;
        private TextBox TextBoxRestTime;
        private TextBox TextBoxLongRestTime;
        private Label LabelWorkTimeMin;
        private Label LabelRestTimeMin;
        private Label LabelLongRestTimeMin;
    }
}