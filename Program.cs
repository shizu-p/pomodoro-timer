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

            // View��Model�̃C���X�^���X���쐬
            MainForm view = new MainForm();
            PomodoroTimer model = new PomodoroTimer();
            PresenterMainForm presenter = new PresenterMainForm(view, model);
            Application.Run(view);
        }
    }
}