﻿using frmWin.fun;
using keshe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmWin
{
    public partial class FrmLogin2 : Form
    {
        public FrmLogin2()
        {
            InitializeComponent();
        }

        private string getstuId()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string sqlquery = @"select stuId from student where stuNum = '" + this.txtUser.Text + "'";
            SqlCommand sql = new SqlCommand(sqlquery, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            string stuid = reader[0].ToString();

            return stuid;
        }

        private string getteacherId()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string sqlquery = @"select teachId from teacher where stuNum = '" + this.txtUser.Text + "'";
            SqlCommand sql = new SqlCommand(sqlquery, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            string teachid = reader[0].ToString();

            return teachid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string userid = this.txtUser.Text;
            string pass = this.txtPass.Text;
            MyGlobal jumpinfo = new MyGlobal();
            if (this.rdoStudent.Checked)
            {
                //学生登录后查询学生信息且有学生权限 
                User.power = "学生";
                SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
                conn.Open();
                string sqlquery = @"select stuName from student where stuNum = '" + userid + "'";
                SqlCommand sql = new SqlCommand(sqlquery, conn);
                SqlDataReader reader = sql.ExecuteReader();
                reader.Read();
                string userName = reader[0].ToString();
                if (reader.HasRows == true) 
                {
                    MessageBox.Show("欢迎学生"+ userName + "登录");
                    jumpinfo.user = "student";
                    jumpinfo.stuid = getstuId();
                }
                this.Hide();
                if (FrmMain.sign == false)
                {
                    FrmMain f = new FrmMain(jumpinfo);
                    //f.MdiParent = this;
                    FrmMain.sign = true;
                    f.Show();

                }
                else
                {
                    MessageBox.Show("该窗体已经存在~");
                    return;
                }

            }
            else
            {
                //教师登录后查询学生信息且有教师权限 
                User.power = "教师";
                SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
                conn.Open();
                string sqlquery = @"select teachName from teacher where teachUserName = '" + userid + "'";
                SqlCommand sql = new SqlCommand(sqlquery, conn);
                SqlDataReader reader = sql.ExecuteReader();
                reader.Read();
                userid = reader[0].ToString();
                if (reader.HasRows == true)
                {
                    MessageBox.Show("欢迎教师" + userid + "登录");
                    jumpinfo.user = "teacher";
                    jumpinfo.stuid = getteacherId();
                }

                this.Hide();
                if (FrmMain.sign == false)
                {
                    FrmMain f = new FrmMain(jumpinfo);
                    //f.MdiParent = this;
                    FrmMain.sign = true;
                    f.Show();

                }
                else
                {
                    MessageBox.Show("该窗体已经存在~");
                    return;
                }

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
