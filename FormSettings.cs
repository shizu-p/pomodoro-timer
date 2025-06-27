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
    public partial class FormSettings : Form,ViewSettingsForm
    {
        public event EventHandler ButtonSaveClicked;
        public event EventHandler ButtonCancelClicked;
        public FormSettings()
        {
            InitializeComponent();

            ButtonSave.Click += (sender, e) => ButtonSaveClicked?.Invoke(this, EventArgs.Empty);
            ButtonCancel.Click += (sender, e) => ButtonCancelClicked?.Invoke(this, EventArgs.Empty);
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

        private void SetWorkTime(string text)
        {
            TextBoxWorkTime.Text = text;
        }

        private void SetRestTime(string text)
        {
            TextBoxRestTime.Text = text;
        }

        private void SetLongRestTime(string text)
        {
            TextBoxLongRestTime.Text = text;
        }   
    }
}
