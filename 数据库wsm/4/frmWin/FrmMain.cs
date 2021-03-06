﻿using frmWin.building;
using frmWin.ClassInfo;
using frmWin.dorm;
using frmWin.dormType;
using frmWin.fun;
using frmWin.Student;
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
        public MyGlobal jumpinfo ;
        public static bool sign = false;
        public FrmMain(MyGlobal jumpinfo1)
        {
            this.jumpinfo = jumpinfo1;
            InitializeComponent();
            //MessageBox.Show("我是"+jumpinfo.user+"id:" + jumpinfo.stuid);
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
            if (dormType == null || dormType.IsDisposed)
            {
                dormType = new dormTypeManageFrm2();
            }
            Size OldSize = dormType.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            dormType.MdiParent = this;
            dormType.Location = new Point(0, 0); ;
            dormType.Show();
        }

        private void 宿舍管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private dormTypeManageFrm2 dormType;
        private void 详细管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dormType == null || dormType.IsDisposed)
            {
                dormType = new dormTypeManageFrm2();
            }
            Size OldSize = dormType.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            dormType.MdiParent = this;
            dormType.Location = new Point(0, 0); ;
            dormType.Show();

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
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
                FrmStu = new FrmStudent();
            }
            Size OldSize = FrmStu.Size;
            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            FrmStu.MdiParent = this;
            FrmStu.Location = new Point(0, 0); ;
            FrmStu.Show();
        }

        private FrmClass FC;
        private void 班级信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (FC == null || FC.IsDisposed)
            {
                FC = new FrmClass();
            }

            Size OldSize = FC.Size;

            this.Size = new Size(OldSize.Width + 20, OldSize.Height + 70);
            FC.MdiParent = this;
            FC.Location = new Point(0, 0);
            FC.Show();
        }
    }
}
