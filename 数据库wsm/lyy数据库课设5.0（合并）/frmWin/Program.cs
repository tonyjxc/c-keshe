using frmWin;
using frmWin.building;
using frmWin.dorm;
using frmWin.dormType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keshe
{
    public class MyGlobal
    {
        public static string ip = "tonyjxc.xyz,6220";
        public string user;
        public string stuId;
        public string teachId;
    }
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new FrmLogin2());

        }
    }
}
