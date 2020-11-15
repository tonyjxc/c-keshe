using frmWin.ClassInfo;
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


        private FrmDormAdd fda;
        private void 宿舍添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fda==null||fda.IsDisposed)
            {
                fda = new FrmDormAdd();
            }

            fda.MdiParent = this;
            fda.Show();
        }

        private void 基础数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private FrmClass FC;
        private void 班级信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (FC == null || FC.IsDisposed)
            {
                FC = new FrmClass();
            }

            Size OldSize = FC.Size;
           
            this.Size = new Size(OldSize.Width+20, OldSize.Height+70);
            FC.MdiParent = this;
            FC.Location = new Point(0, 0);
            FC.Show();
        }

        private AddClass AddC;
        private void 添加班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddC == null || AddC.IsDisposed)
            {
                AddC = new AddClass();
            }
            Size OldSize = AddC.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            AddC.MdiParent = this;
            AddC.Location = new Point(0, 0); ;
            AddC.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
