using System;
using System.Windows.Forms;

namespace pomodoro_timer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ViewとModelのインスタンスを作成
            var mainForm = new MainForm();
            var pomodoroTimer = new PomodoroTimer();
            var presenter = new PresenterMainForm(mainForm, pomodoroTimer);
            var settingsForm = new FormSettings(pomodoroTimer);
            var presenterSettings = new PresenterSettingsForm(settingsForm, mainForm, pomodoroTimer);
            Application.Run(mainForm);
        }
    }
}