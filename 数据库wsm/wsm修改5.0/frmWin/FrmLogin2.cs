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
        public string getstuId()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string sqlquery = @"select stuId from student where stuNum = '" + this.txtUser.Text + "'";
            SqlCommand sql = new SqlCommand(sqlquery, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            return reader[0].ToString();
        }

        public string getteachId()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string sqlquery = @"select teachId from teacher where teachUserName = '" + this.txtUser.Text + "'";
            SqlCommand sql = new SqlCommand(sqlquery, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            return reader[0].ToString();
        }
        public FrmLogin2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MyGlobal jumpinfo = new MyGlobal();
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
                
                if (reader.HasRows == true) 
                {
                    userid = reader[0].ToString();
                    MessageBox.Show("欢迎学生"+userid+"登录");
                    jumpinfo.user = "student";
                    jumpinfo.stuId = getstuId();
                    this.Hide();
                    FrmMain f = new FrmMain(jumpinfo);
                    //f.MdiParent = this;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("该生不存在哟！");
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
                
                
                bool flag = reader.HasRows;
                if (flag == true)
                {
                    userid = reader[0].ToString();
                    MessageBox.Show("欢迎教师" + userid + "登录");
                    jumpinfo.user = "teacher";
                    jumpinfo.teachId = getteachId();
                    this.Hide();
                    this.Hide();
                    FrmMain f = new FrmMain(jumpinfo);
                    //f.MdiParent = this;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("该教师不存在哟！");
                }


            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
