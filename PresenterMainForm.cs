using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoro_timer
{
    internal class PresenterMainForm
    {
        private readonly PomodoroView _view;
        private readonly PomodoroTimer _model;
        private readonly Control _uiControl;

        public PresenterMainForm(PomodoroView view)
        {
            _view = view;
            _model = new PomodoroTimer();
            _uiControl = _view.GetControl();

            _model.TimerTicked += OnModelTimerTicked;
            _model.StateChanged += OnModelStateChanged;

            _view.StartStopButtonClicked += OnViewStartStopButtonClicked;

            UpdateViewFromModel();

        }

        private void OnModelTimerTicked(object sender, EventArgs e)
        {
            _uiControl.Invoke(new MethodInvoker(() =>
            {
                TimeSpan time = TimeSpan.FromSeconds(_model.RemainingTime);
                _view.DisplayRemainingTime(time.ToString(@"mm\:ss"));
            }));
        }

        private void OnModelStateChanged(object sender, EventArgs e)
        {
            _uiControl.Invoke(new MethodInvoker(UpdateViewFromModel));
        }

        private void UpdateViewFromModel()
        {
           
        }
    }
}
