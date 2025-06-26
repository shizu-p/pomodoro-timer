namespace pomodoro_timer
{
    partial class MainForm
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
            ButtonStartStop = new Button();
            ButtonReset = new Button();
            LabelTimer = new Label();
            LabelTimes = new Label();
            ButtonSettings = new Button();
            ButtonSkip = new Button();
            LabelStatus = new Label();
            SuspendLayout();
            // 
            // ButtonStartStop
            // 
            ButtonStartStop.Location = new Point(45, 380);
            ButtonStartStop.Name = "ButtonStartStop";
            ButtonStartStop.Size = new Size(234, 95);
            ButtonStartStop.TabIndex = 0;
            ButtonStartStop.Text = "スタート";
            ButtonStartStop.UseVisualStyleBackColor = true;
            //ButtonStartStop.Click += ButtonStartStop.Click;
            // 
            // ButtonReset
            // 
            ButtonReset.Location = new Point(463, 380);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(205, 77);
            ButtonReset.TabIndex = 1;
            ButtonReset.Text = "リセット";
            ButtonReset.UseVisualStyleBackColor = true;
            // 
            // LabelTimer
            // 
            LabelTimer.AutoSize = true;
            LabelTimer.Font = new Font("Yu Gothic UI", 70F);
            LabelTimer.ForeColor = Color.LightGreen;
            LabelTimer.Location = new Point(135, 153);
            LabelTimer.Name = "LabelTimer";
            LabelTimer.Size = new Size(558, 155);
            LabelTimer.TabIndex = 2;
            LabelTimer.Text = "時刻:時刻";
            // 
            // LabelTimes
            // 
            LabelTimes.AutoSize = true;
            LabelTimes.Font = new Font("Yu Gothic UI", 25F);
            LabelTimes.Location = new Point(319, 31);
            LabelTimes.Name = "LabelTimes";
            LabelTimes.Size = new Size(181, 57);
            LabelTimes.TabIndex = 3;
            LabelTimes.Text = "1セット目";
            // 
            // ButtonSettings
            // 
            ButtonSettings.Location = new Point(708, 398);
            ButtonSettings.Name = "ButtonSettings";
            ButtonSettings.Size = new Size(82, 77);
            ButtonSettings.TabIndex = 4;
            ButtonSettings.Text = "設定";
            ButtonSettings.UseVisualStyleBackColor = true;
            // 
            // ButtonSkip
            // 
            ButtonSkip.Location = new Point(285, 361);
            ButtonSkip.Name = "ButtonSkip";
            ButtonSkip.Size = new Size(153, 114);
            ButtonSkip.TabIndex = 5;
            ButtonSkip.Text = "スキップ";
            ButtonSkip.UseVisualStyleBackColor = true;
            // 
            // LabelStatus
            // 
            LabelStatus.AutoSize = true;
            LabelStatus.Font = new Font("Yu Gothic UI", 30F);
            LabelStatus.Location = new Point(319, 101);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(179, 67);
            LabelStatus.TabIndex = 6;
            LabelStatus.Text = "作業中";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(836, 505);
            Controls.Add(LabelStatus);
            Controls.Add(ButtonSkip);
            Controls.Add(ButtonSettings);
            Controls.Add(LabelTimes);
            Controls.Add(LabelTimer);
            Controls.Add(ButtonReset);
            Controls.Add(ButtonStartStop);
            Name = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonStartStop;
        private Button ButtonReset;
        private Label LabelTimer;
        private Label LabelTimes;
        private Button ButtonSettings;
        private Button ButtonSkip;
        private Label LabelStatus;
    }
}
