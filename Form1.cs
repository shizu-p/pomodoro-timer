    using System;
    using System.Windows.Forms;


    namespace pomodoro_timer
    {
        public partial class MainForm : Form, PomodoroView
        {
            public event EventHandler ButtonStartStopClicked;
            public event EventHandler TimerTicked;

            private readonly System.Windows.Forms.Timer FormTimer;

            public MainForm()
            {
                InitializeComponent();

                FormTimer = new System.Windows.Forms.Timer();
                FormTimer.Interval = 1000;
                FormTimer.Tick += (sender, e) => TimerTicked?.Invoke(this, EventArgs.Empty);

            //UI‚Ìclick‚ðPresenter‚ªw“Ç‚·‚éButtonStartStopClicked‚É•R‚Ã‚¯
            ButtonStartStop.Click += (sender, e) =>
            {
                MessageBox.Show("ButtonStartStop Clicked");
                ButtonStartStopClicked?.Invoke(this, EventArgs.Empty);
            };


            }

            public void UpdateTimerDisplay(string ReminingTimer)
            {
                LabelTimer.Text = ReminingTimer;
            }

            public void StartTimer()
            {
                FormTimer.Start();
            }

            public void StopTimer()
            {
                FormTimer.Stop();
            }
        }
    }
