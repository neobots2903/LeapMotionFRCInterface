using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leap_Motion_FRC_Interface
{
    class TxtDataFormatter
    {
        static TextBox txtbox;
        public static void Init(TextBox _txtbox)
        {
            txtbox = _txtbox;
        }

        public static string getMessage()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Network Table Data:");
            if (MainForm.inst.IsConnected()) {
                foreach (string entry in MainForm.table.GetKeys())
                    sb.AppendLine(entry + ": " + MainForm.table.GetEntry(entry).GetDouble(0));
            } else {
                if (MainForm.teamNum == -1)
                    sb.AppendLine("Waiting for team number...");
                else
                    sb.AppendLine("Not currently connected to " + MainForm.teamNum + " RoboRIO.");
            }
            return sb.ToString();
        }
    }
}
