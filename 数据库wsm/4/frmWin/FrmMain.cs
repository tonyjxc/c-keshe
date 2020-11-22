using frmWin.fun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmWin
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 学生档案录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 楼层管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleWindow.bmf.MdiParent = this;
            SingleWindow.bmf.Show();
        }

        private void 宿舍类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleWindow.dtmf.MdiParent = this;
            SingleWindow.dtmf.Show();
        }

        private void 宿舍管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SingleWindow.buf.MdiParent = this;
            SingleWindow.buf.Show();
        }
    }
}
