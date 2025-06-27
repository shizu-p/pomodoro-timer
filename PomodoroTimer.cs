using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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


        // 残り時間が1秒減るごとにUIタイマー更新
        public event EventHandler StateChanged;
        public PomodoroTimer()
        {
            IsInWork = true;
            WorkTime = 25;
            RestTime = 5;
            LongRestTime = 20;
            SetTimes = 0;
            IsInCounting = false;

            RemainingTime = WorkTime * 60;
        }

        public void StartCounting()
        {
            if (IsInCounting) return;
            IsInCounting = true;
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void StopCounting()
        {
            if (!IsInCounting) return;
            IsInCounting = false;
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void DecrementTime()
        {
            if (IsInCounting)
            {
                RemainingTime--;
                StateChanged?.Invoke(this, EventArgs.Empty);
                if (RemainingTime <= 0)
                {
                    IsInWork = !IsInWork;
                    if (IsInWork)
                    {
                        RemainingTime = WorkTime * 60;
                        SetTimes++;
                    }
                    else
                    {
                        RemainingTime = (SetTimes % 4 == 3) ? LongRestTime * 60 : RestTime * 60;

                    }

                    StateChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public void Skip()
        {
            if (IsInWork)
            {
                IsInWork = false;
                RemainingTime = (SetTimes % 4 == 3) ? LongRestTime * 60 : RestTime * 60;
            }
            else
            {
                IsInWork = true;
                RemainingTime = WorkTime * 60;
                SetTimes++;
            }
            IsInCounting = true;
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Reset()
        {
            StopCounting();
            IsInWork = true;
            WorkTime = 25;
            RestTime = 5;
            LongRestTime = 20;
            SetTimes = 0;
            IsInCounting = false;
            RemainingTime = WorkTime * 60;
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void SetWorkTime(int WorkTime)
        {
            this.WorkTime = WorkTime;
        }
        public void SetRestTime(int RestTime)
        {
            this.RestTime = RestTime;
        }
        public void SetLongRestTime(int LongRestTime)
        {
            this.LongRestTime = LongRestTime;
        }
    }
}
