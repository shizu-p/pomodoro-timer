using System;

namespace pomodoro_timer
{
    public interface PomodoroView
    {
        // Presenterに通知するイベント
        event EventHandler ButtonStartStopClicked;

        // Viewがもつタイマーが刻んだことをPresenterに通知
        event EventHandler TimerTicked;

        // Presenter が ViewのUIを更新
        void UpdateTimerDisplay(string RemainingTimer);

        void StartTimer();
        void StopTimer();
    }
}
