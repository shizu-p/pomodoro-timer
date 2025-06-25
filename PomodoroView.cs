using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoro_timer
{
    internal class PomodoroView
    {
        //PresenterからViewへの通知
        void DisplayRemainingTime(string time);
        void DisplaySetInfo(string info);
        void DisplayStatus(string status);
        void SetStartStopButtonText(string text);

        // ViewからPresenterへの通知
        event EventHandler StartStopButtonClicked;

        // PresenterからUIへのInvokeに使うためのControlインスタンスを取得するためのメソッド
        public Control GetControl();
    }
}
