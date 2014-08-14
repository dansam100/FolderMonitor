using System.Windows.Forms;

namespace FolderMonitor
{
    class Confirmations
    {
        private const string removeMonitee = "removemonitee";

        public static DialogResult Confirm(string what)
        {
            switch (what)
            {
                case removeMonitee:
                   return MessageBox.Show("This folder has no more destinations. Do you want tho remove it from your monitored list?\n"+
                        "If not, the removed destination will be reverted.",
                                    "Remove file/folder?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            return DialogResult.No;
        }
    }
}
