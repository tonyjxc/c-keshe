using frmWin.fun;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userid = this.txtUser.Text;
            string pass = this.txtPass.Text;
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
                userid = reader[0].ToString();
                if (reader.HasRows == true) 
                {
                    MessageBox.Show("欢迎学生"+userid+"登录");
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
                }

                this.Hide();
                if (FrmMain.sign == false)
                {
                    FrmMain f = new FrmMain();
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
