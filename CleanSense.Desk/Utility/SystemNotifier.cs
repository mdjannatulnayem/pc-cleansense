using System.Windows.Forms;

namespace CleanSense.Desk.Utility
{
    public static class SystemNotifier
    {
        public static void Notify(string msg_head,string msg,NotifyIcon notifier)
        {
            notifier.Visible = true;
            notifier.BalloonTipText = msg;
            notifier.BalloonTipTitle = msg_head;
            notifier.ShowBalloonTip(100);
        }
    }
}
