    using System;
    using System.Windows.Forms;


    namespace pomodoro_timer
    {
        public partial class MainForm : Form, PomodoroView
        {
            public event EventHandler ButtonStartStopClicked;
            public event EventHandler TimerTicked;
       
            public event  EventHandler ButtonSkipClicked;

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


            }

            public void UpdateTimerDisplay(string ReminingTimer)
            {
                LabelTimer.Text = ReminingTimer;
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
