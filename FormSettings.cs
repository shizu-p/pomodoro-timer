using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodoro_timer
{
    public partial class FormSettings : Form, ViewSettingsForm
    {
        public event EventHandler ButtonSaveClicked;
        public event EventHandler ButtonCancelClicked;

        private readonly PomodoroTimer _model;
        public FormSettings(PomodoroTimer model)
        {
            InitializeComponent();

            ButtonSave.Click += (sender, e) => ButtonSaveClicked?.Invoke(this, EventArgs.Empty);
            ButtonCancel.Click += (sender, e) => ButtonCancelClicked?.Invoke(this, EventArgs.Empty);
            // 初期値を設定
            _model = model;
            this.TextBoxWorkTime.Text = _model.WorkTime.ToString();
            this.TextBoxRestTime.Text = _model.RestTime.ToString();
            this.TextBoxLongRestTime.Text = _model.LongRestTime.ToString();
        }

        public string InputWorkTime
        {
            get { return TextBoxWorkTime.Text; }
        }

        public string InputRestTime
        {
            get { return TextBoxRestTime.Text; }
        }

        public string InputLongRestTime
        {
            get { return TextBoxLongRestTime.Text; }
        }



    }
}
