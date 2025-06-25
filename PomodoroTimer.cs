using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace pomodoro_timer
{
    public class PomodoroTimer
    {
        public bool IsInWork { get; private set; }
        public int WorkTime { get; private set; }
        public int RestTime { get; private set; }
        public int LongRestTime { get; private set; }
        public int SetTimes { get; private set; }
        public bool IsInCounting { get; private set; }

        public int RemainingTime { get; private set; }
        private System.Timers.Timer timer;
        // 残り時間が1秒減るごとにUIタイマー更新
        public event EventHandler TimerTicked;

        // 状態が変わるごとにUI更新
        public event EventHandler StateChanged;

        // バリデーションに失敗したときのイベント
        public event EventHandler<string> ValidationFailed;

        public PomodoroTimer()
        {
            IsInWork = true;
            WorkTime = 25;
            RestTime = 5;
            LongRestTime = 20;
            SetTimes = 0;
            IsInCounting = false;

            RemainingTime = WorkTime * 60;
            timer = new System.Timers.Timer(1000); // 1秒ごとにタイマーイベントを発生
            timer.Elapsed += OnTimerElapsed;

 
        }

        private void OnTimerElapsed(object sender,ElapsedEventArgs e)
        {
            TimerTicked?.Invoke(this, EventArgs.Empty);     
            this.RemainingTime--;
            if (RemainingTime <= 0)
            {
                if (IsInWork)
                {
                    RemainingTime = (SetTimes % 4 == 3) ? LongRestTime * 60 : RestTime * 60;
                } else
                {
                    RemainingTime = WorkTime * 60;
                    SetTimes++;
                }
                IsInWork = !IsInWork;
                StateChanged?.Invoke(this, EventArgs.Empty);    
            }
        }

        // Presenterから呼ばれる
        public void StartTimer()
        {
            if (IsInCounting)
            {
                return; // すでにカウント中なら何もしない
            }
            this.timer.Start();
            IsInCounting = true;
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void StopTimer()
        {
            if (!IsInCounting)
            {
                return; // カウント中でなければ何もしない
            }
            this.timer.Stop();
            IsInCounting = false;
            StateChanged?.Invoke(this,EventArgs.Empty);
        }

        public void SkipTimer()
        {
            StopTimer();
            if(IsInWork)
            {
                RemainingTime = (SetTimes % 4 == 3) ? LongRestTime * 60 : RestTime * 60;
            }
            else
            {
                RemainingTime = WorkTime * 60;
                SetTimes++;
            }
            IsInWork = !IsInWork;

            if (!IsInCounting)
            {
                IsInCounting = true;
            }

            // イベントを発火してUIを更新
            StateChanged?.Invoke(this, EventArgs.Empty);
            TimerTicked?.Invoke(this, EventArgs.Empty);

            // タイマーを再スタート
            StartTimer();
        }

        public void ResetTimer()
        {
            StopTimer();
            RemainingTime = WorkTime * 60;
            IsInCounting = false;
            IsInWork = true;
            SetTimes = 0;

            // イベントを発火してUIを更新
            StateChanged?.Invoke(this, EventArgs.Empty);
            TimerTicked?.Invoke(this, EventArgs.Empty); 
        }

        public bool ChangeTimer(int WorkTime, int RestTimer, int LongRestTime)
        {
            if(WorkTime <= 0 || RestTimer < 0 || LongRestTime < 0)
            {
                ValidationFailed?.Invoke(this, "時間は正の整数でなければなりません。");
                return false;
            }
            this.WorkTime = WorkTime;
            this.RestTime = RestTimer;
            this.LongRestTime = LongRestTime;

            StateChanged?.Invoke(this, EventArgs.Empty);
            TimerTicked?.Invoke(this, EventArgs.Empty); 
            return true;
        }
    }
}
