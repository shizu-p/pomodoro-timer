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

            int WorkTime;
            int.TryParse(_view.InputWorkTime,out WorkTime);
            int RestTime;
            int.TryParse(_view.InputRestTime,out RestTime);
            int LongRestTime;
            int.TryParse(_view.InputLongRestTime,out LongRestTime);
            if(WorkTime < 1 || 60 < WorkTime ||
                RestTime < 1 || 60 < RestTime ||
                LongRestTime < 1 || 60 < LongRestTime)
            {
                MessageBox.Show(
                    "整数値であり、かつ1以上60以下の値を入力してください。",
                    "入力エラー",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
                return;
            }
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
