using frmWin.building;
using frmWin.ClassInfo;
using frmWin.dorm;
using frmWin.dormType;
using frmWin.fun;
using frmWin.Student;
using frmWin.teacher;
using keshe;
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
        public MyGlobal jumpinfo;
        public FrmMain(MyGlobal jumpinfo2)
        {
            this.jumpinfo = jumpinfo2;
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

        private buildingManagerFrm2 buildingman;
        private void 楼层管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (buildingman == null || buildingman.IsDisposed)
            {
                buildingman = new buildingManagerFrm2(jumpinfo);
            }
            Size OldSize = buildingman.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            buildingman.MdiParent = this;
            buildingman.Location = new Point(0, 0); ;
            buildingman.Show();
        }

        private void 宿舍类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dormtype == null || dormtype.IsDisposed)
            {
                dormtype = new dormTypeManageFrm2(jumpinfo);
            }
            Size OldSize = dormtype.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            dormtype.MdiParent = this;
            dormtype.Location = new Point(0, 0); ;
            dormtype.Show();
        }

        private void 宿舍管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private dormTypeManageFrm2 dormtype;
        private void 详细管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dormtype == null || dormtype.IsDisposed)
            {
                dormtype = new dormTypeManageFrm2(jumpinfo);
            }
            Size OldSize = dormtype.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            dormtype.MdiParent = this;
            dormtype.Location = new Point(0, 0); ;
            dormtype.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private FrmClass FC;
        private void 班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FC == null || FC.IsDisposed)
            {
                FC = new FrmClass(jumpinfo);
            }

            Size OldSize = FC.Size;

            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            FC.MdiParent = this;
            FC.Location = new Point(0, 0);
            FC.Show();
        }
        private AddClass AddC;
        private void 添加班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddC == null || AddC.IsDisposed)
            {
                AddC = new AddClass(jumpinfo);
            }
            Size OldSize = AddC.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            AddC.MdiParent = this;
            AddC.Location = new Point(0, 0); ;
            AddC.Show();
        }

        private NoClassStuFrm NCStu;
        private void 学生班级分配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NCStu == null || NCStu.IsDisposed)
            {
                NCStu = new NoClassStuFrm();
            }
            Size OldSize = NCStu.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            NCStu.MdiParent = this;
            NCStu.Location = new Point(0, 0); ;
            NCStu.Show();
        }

        private FrmStudent FrmStu;
        private void 学生档案查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmStu == null || FrmStu.IsDisposed)
            {
                FrmStu = new FrmStudent(jumpinfo);
            }
            Size OldSize = FrmStu.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            FrmStu.MdiParent = this;
            FrmStu.Location = new Point(0, 0); ;
            FrmStu.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private FrmTeacher frmteacher;
        private void 教师查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmteacher == null || frmteacher.IsDisposed)
            {
                frmteacher = new FrmTeacher(jumpinfo);
            }
            Size OldSize = frmteacher.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            frmteacher.MdiParent = this;
            frmteacher.Location = new Point(0, 0); ;
            frmteacher.Show();
        }

        private ChangeTeachInfo ChangeTeacher;
        private void 教师信息修改老师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ChangeTeacher == null || ChangeTeacher.IsDisposed)
            {
                ChangeTeacher = new ChangeTeachInfo(jumpinfo);
            }
            Size OldSize = ChangeTeacher.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            ChangeTeacher.MdiParent = this;
            ChangeTeacher.Location = new Point(0, 0); ;
            ChangeTeacher.Show();
        }

        private void 教师档案录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private ChangeStuInfo ChangeStu;
        private void 学生信息修改学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ChangeStu == null || ChangeStu.IsDisposed)
            {
                ChangeStu = new ChangeStuInfo(jumpinfo);
            }
            Size OldSize = ChangeStu.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            ChangeStu.MdiParent = this;
            ChangeStu.Location = new Point(0, 0); ;
            ChangeStu.Show();
        }

        private void 更换账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin2 start = new FrmLogin2();
            start.Show();
            this.Hide();
        }
    }
}
