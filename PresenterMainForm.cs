﻿using System;

namespace pomodoro_timer
{
    public class PresenterMainForm
    {
        private readonly PomodoroView _view;
        private readonly PomodoroTimer _model;

        public PresenterMainForm(PomodoroView view, PomodoroTimer model)
        {
            _view = view;
            _model = model;

            _view.ButtonStartStopClicked += OnViewButtonStartStopClicked;
            _view.TimerTicked += OnViewTimerTicked;
            _view.UpdateTimerDisplay(TimeSpan.FromSeconds(_model.RemainingTime).ToString(@"mm\:ss"),TimesStr());
            _view.ButtonSkipClicked += OnViewButtonSkipClicked;
            _view.ButtonResetClicked += OnViewButtonResetClicked;
            
            _model.StateChanged += OnModelStateChanged;
        }

        private void OnModelStateChanged(object sender,EventArgs e)
        {
            string RemainingTime = TimeSpan.FromSeconds(_model.RemainingTime).ToString(@"mm\:ss");
            _view.UpdateTimerDisplay(RemainingTime,TimesStr());
        }
        private void OnViewButtonStartStopClicked(object sender, EventArgs e)
        {
            if (_model.IsInCounting)
            {
                _model.StopCounting();
                _view.StopTimer();

            }
            else
            {
                _model.StartCounting();
                _view.StartTimer();
            }
        }

        private void OnViewTimerTicked(object sender, EventArgs e)
        {
            // 時間を1秒減らす
            _model.DecrementTime();

            // Modelからの残り時間を取得
            string RemainingTime = TimeSpan.FromSeconds(_model.RemainingTime).ToString(@"mm\:ss");
            //ViewにUIを更新してもらう
            _view.UpdateTimerDisplay(RemainingTime, TimesStr());
        }

        private void OnViewButtonSkipClicked(object sender, EventArgs e)
        {
            _model.Skip();
            _model.StartCounting();
            _view.StartTimer();
            string RemainingTime = TimeSpan.FromSeconds(_model.RemainingTime).ToString(@"mm\:ss");
            _view.UpdateTimerDisplay(RemainingTime,TimesStr());
            
        }

        private void OnViewButtonResetClicked(object sender, EventArgs e)
        {
            _model.Reset();
            _view.UpdateTimerDisplay(TimeSpan.FromSeconds(_model.RemainingTime).ToString(@"mm\:ss"),TimesStr());
            _view.StopTimer();
        }

        public string TimesStr()
        {
            string SetTimes = (_model.SetTimes + 1).ToString();
            SetTimes += "セット目";
            return SetTimes;
        }
    }
}
