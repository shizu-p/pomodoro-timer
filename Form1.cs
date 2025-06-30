using System;
using System.Windows.Forms;


namespace pomodoro_timer
{
    public partial class MainForm : Form, PomodoroView
    {
        public event EventHandler ButtonStartStopClicked;
        public event EventHandler TimerTicked;

        public event EventHandler ButtonSkipClicked;
        public event EventHandler ButtonResetClicked;

        public event EventHandler ButtonSettingsClicked;

        private readonly System.Windows.Forms.Timer FormTimer;

        public MainForm()
        {
            InitializeComponent();

            FormTimer = new System.Windows.Forms.Timer();
            FormTimer.Interval = 1000;
            FormTimer.Tick += (sender, e) => TimerTicked?.Invoke(this, EventArgs.Empty);

            //UIのclickをPresenterが購読するButtonStartStopClickedに紐づけ
            ButtonStartStop.Click += (sender, e) =>
            {
                ButtonStartStopClicked?.Invoke(this, EventArgs.Empty);
            };

            ButtonSkip.Click += (sender, e) =>
            {
                ButtonSkipClicked?.Invoke(this, EventArgs.Empty);
            };

            ButtonReset.Click += (sender, e) =>
            {
                ButtonResetClicked?.Invoke(this, EventArgs.Empty);
            };

            ButtonSettings.Click += (sender, e) =>
            {
                ButtonSettingsClicked?.Invoke(this, EventArgs.Empty);
            };

            InitResize();

        }

        private void InitResize()
        {
            
            LabelTimer.Location = new Point((this.Width-LabelTimer.Width)/2,(this.Height-LabelTimer.Height)/2);
            LabelTimes.Location = new Point((this.Width - LabelTimes.Width) / 2, ((this.Height - LabelTimes.Height) / 7)*2);
            LabelStatus.Location = new Point((this.Width - LabelStatus.Width) / 2, (this.Height - LabelStatus.Height) / 7);
            int ButtonXMargin = 10;
            int ButtonYMargin = 60;
            int ButtonX = (this.Width - ButtonStartStop.Width * 3 + ButtonXMargin * 2) / 2;
            ButtonStartStop.Location = new Point(ButtonX, this.Height - ButtonStartStop.Height - ButtonYMargin);
            ButtonSkip.Location = new Point(ButtonX + ButtonStartStop.Width +ButtonXMargin, this.Height - ButtonSkip.Height - ButtonYMargin);
            ButtonReset.Location = new Point(ButtonX + ButtonStartStop.Width * 2 + ButtonXMargin * 2, this.Height - ButtonReset.Height - ButtonYMargin);
        }

        public void UpdateTimerDisplay(string ReminingTimer, string SetTimes)
        {
            LabelTimer.Text = ReminingTimer;
            LabelTimes.Text = SetTimes;
        }

        public void StartTimer()
        {
            FormTimer.Start();
            ButtonStartStop.Text = "ストップ";
        }

        public void StopTimer()
        {
            FormTimer.Stop();
            ButtonStartStop.Text = "スタート";
        }
    }
}
