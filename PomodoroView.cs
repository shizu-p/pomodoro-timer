using System;

namespace pomodoro_timer
{
    public interface PomodoroView
    {
        // Presenterに通知するイベント
        event EventHandler ButtonStartStopClicked;

        // Viewがもつタイマーが刻んだことをPresenterに通知
        event EventHandler TimerTicked;

        event EventHandler ButtonSkipClicked;

        // リセットボタンがクリックされたことをPresenterに通知
        event EventHandler ButtonResetClicked;

        // Presenter が ViewのUIを更新
        void UpdateTimerDisplay(string RemainingTimer,string SetTimes);

        void StartTimer();
        void StopTimer();
    }
}
