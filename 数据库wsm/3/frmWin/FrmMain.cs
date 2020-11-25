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
    }
}
