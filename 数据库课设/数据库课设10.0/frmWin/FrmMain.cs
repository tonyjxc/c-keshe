using frmWin.building;
using frmWin.ClassInfo;
using frmWin.dorm;
using frmWin.chargeType;
using frmWin.charge;
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

        private AddStudent addstu;
        private void 学生档案录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addstu == null || addstu.IsDisposed)
            {
                addstu = new AddStudent(jumpinfo);
            }
            Size OldSize = addstu.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            addstu.MdiParent = this;
            addstu.Location = new Point(0, 0); ;
            addstu.Show();
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
        private dormTypeManageFrm2 dormtype;
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

        private dormManageFrm2 mydorm;
        private void 详细管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mydorm == null || mydorm.IsDisposed)
            {
                mydorm = new dormManageFrm2(jumpinfo);
            }
            Size OldSize = mydorm.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            mydorm.MdiParent = this;
            mydorm.Location = new Point(0, 0); ;
            mydorm.Show();
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
            teacher.Form1 AddTeacher = new teacher.Form1(jumpinfo.teachId);
            AddTeacher.Show();
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

        private void 教师信息查询校长ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (teacher.Form2.sign == false)
            {
                teacher.Form2 f = new teacher.Form2(jumpinfo);
                //f.MdiParent = this;
                teacher.Form2.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }

        private void 收费管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (charge.Form2.sign == false)
            {
                charge.Form2 f = new charge.Form2(jumpinfo);
                //f.MdiParent = this;
                charge.Form2.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }

        private void 种类管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chargeType.Form2.sign == false)
            {
                chargeType.Form2 f = new chargeType.Form2(jumpinfo);
                //f.MdiParent = this;
                chargeType.Form2.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }

        private stuenterdorm stuentdorm;
        private void 学生宿舍入住ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stuentdorm == null || stuentdorm.IsDisposed)
            {
                stuentdorm = new stuenterdorm(jumpinfo);
            }
            Size OldSize = stuentdorm.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            stuentdorm.MdiParent = this;
            stuentdorm.Location = new Point(0, 0); ;
            stuentdorm.Show();
        }

        private void 收费统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (charge.Form4.sign == false)
            {
                charge.Form4 f = new charge.Form4(jumpinfo);
                //f.MdiParent = this;
                charge.Form4.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }

        private void 收费统计教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (charge.Form5.sign == false)
            {
                charge.Form5 f = new charge.Form5(jumpinfo);
                //f.MdiParent = this;
                charge.Form5.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }
    }
}
