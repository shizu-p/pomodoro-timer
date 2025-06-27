using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoro_timer
{
    public interface ViewSettingsForm
    {
        // 押されたらPresenterに通知
        event EventHandler ButtonSaveClicked;
        event EventHandler ButtonCancelClicked;
        

        string InputWorkTime { get; }
        string InputRestTime { get; }
        string InputLongRestTime { get; }   
        
    }
}
