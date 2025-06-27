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
            SuspendLayout();
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(361, 345);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(206, 77);
            ButtonSave.TabIndex = 0;
            ButtonSave.Text = "保存";
            ButtonSave.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(587, 352);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(176, 70);
            ButtonCancel.TabIndex = 1;
            ButtonCancel.Text = "キャンセル";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // LabelWorkTime
            // 
            LabelWorkTime.AutoSize = true;
            LabelWorkTime.Location = new Point(82, 93);
            LabelWorkTime.Name = "LabelWorkTime";
            LabelWorkTime.Size = new Size(69, 20);
            LabelWorkTime.TabIndex = 2;
            LabelWorkTime.Text = "作業時間";
            // 
            // LabelRestTime
            // 
            LabelRestTime.AutoSize = true;
            LabelRestTime.Location = new Point(311, 89);
            LabelRestTime.Name = "LabelRestTime";
            LabelRestTime.Size = new Size(69, 20);
            LabelRestTime.TabIndex = 3;
            LabelRestTime.Text = "休憩時間";
            // 
            // LabelLongRestTime
            // 
            LabelLongRestTime.AutoSize = true;
            LabelLongRestTime.Location = new Point(495, 72);
            LabelLongRestTime.Name = "LabelLongRestTime";
            LabelLongRestTime.Size = new Size(96, 20);
            LabelLongRestTime.TabIndex = 4;
            LabelLongRestTime.Text = "長い休憩時間";
            // 
            // TextBoxWorkTime
            // 
            TextBoxWorkTime.Location = new Point(78, 155);
            TextBoxWorkTime.Name = "TextBoxWorkTime";
            TextBoxWorkTime.Size = new Size(101, 27);
            TextBoxWorkTime.TabIndex = 5;
            // 
            // TextBoxRestTime
            // 
            TextBoxRestTime.Location = new Point(303, 156);
            TextBoxRestTime.Name = "TextBoxRestTime";
            TextBoxRestTime.Size = new Size(127, 27);
            TextBoxRestTime.TabIndex = 6;
            // 
            // TextBoxLongRestTime
            // 
            TextBoxLongRestTime.Location = new Point(507, 153);
            TextBoxLongRestTime.Name = "TextBoxLongRestTime";
            TextBoxLongRestTime.Size = new Size(116, 27);
            TextBoxLongRestTime.TabIndex = 7;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}