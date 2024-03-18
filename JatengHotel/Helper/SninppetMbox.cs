using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatengHotel.Helper
{
    public class SninppetMbox
    {
        public static void Information(string title, string msg)
        {
            System.Windows.Forms.MessageBox.Show(
                msg,
                title,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information
                );
        }

        public static void Error(string title, string msg)
        {
            System.Windows.Forms.MessageBox.Show(
                msg, 
                title,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error
                );
        }

        public static void Warning(string title, string msg)
        {
            System.Windows.Forms.MessageBox.Show(
                msg,
                title, 
                System.Windows.Forms.MessageBoxButtons.OKCancel,
                System.Windows.Forms.MessageBoxIcon.Warning
                );
        }
    }
}
