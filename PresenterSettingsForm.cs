using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoro_timer
{
    internal class PresenterSettingsForm
    {
        private readonly ViewSettingsForm _view;
        private readonly PomodoroView _pview;
        private readonly PomodoroTimer _model;

        public PresenterSettingsForm(ViewSettingsForm view, PomodoroView pview, PomodoroTimer model)
        {
            _view = view;
            _pview = pview;
            _model = model;

            _view.ButtonSaveClicked += OnViewButtonSaveClicked;
            _view.ButtonCancelClicked += OnViewButtonCancelClicked;
            _pview.ButtonSettingsClicked += OnViewButtonSettingsClicked;
        }

        private void OnViewButtonSaveClicked(object sender, EventArgs a)
        {
            int WorkTime = int.Parse(_view.InputWorkTime);
            int RestTime = int.Parse(_view.InputRestTime);
            int LongRestTime = int.Parse(_view.InputLongRestTime);
            _model.SetWorkTime(WorkTime);
            _model.SetRestTime(RestTime);
            _model.SetLongRestTime(LongRestTime);

            MessageBox.Show("設定を保存しました。\n次フェーズから適用されます。");
            var SettingsForm = _view as Form;
            SettingsForm?.Close();

        }
        private void OnViewButtonCancelClicked(object sender, EventArgs a)
        {
            var SettingsForm = _view as Form;
            SettingsForm?.Close();
        }
        private void OnViewButtonSettingsClicked(object sender, EventArgs a)
        {
            var SettingsForm = _view as Form;
            if (SettingsForm != null)
            {
                SettingsForm.ShowDialog();
            }
        }


    }
}
