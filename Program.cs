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
            var MainForm = new MainForm();
            var PomodoroTimer  = new PomodoroTimer();
            var Presenter = new PresenterMainForm(MainForm, PomodoroTimer);
            Application.Run(MainForm);
        }
    }
}