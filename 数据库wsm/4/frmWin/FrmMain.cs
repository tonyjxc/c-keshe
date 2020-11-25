using frmWin.building;
using frmWin.dorm;
using frmWin.dormType;
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
        public static bool sign = false;
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
            
            if (buildingManagerFrm2.sign == false)
            {
                buildingManagerFrm2 f = new buildingManagerFrm2();
                //f.MdiParent = this;
                buildingManagerFrm2.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
            
        }

        private void 宿舍类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dormTypeManageFrm2.sign == false)
            {
                dormTypeManageFrm2 f = new dormTypeManageFrm2();
                //f.MdiParent = this;
                dormTypeManageFrm2.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }

        private void 宿舍管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void 详细管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dormTypeManageFrm2.sign == false)
            {
                dormTypeManageFrm2 f = new dormTypeManageFrm2();
                //f.MdiParent = this;
                dormTypeManageFrm2.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
        }
    }
}
