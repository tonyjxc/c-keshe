using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;//dbhelper 数据库帮助类
using System.Data.SqlClient;
using frmWin.wsm;


namespace frmWin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录点击事件,判断用户身份
        /// </summary>
        /// 
        LoginInfo loin = new LoginInfo();

        public void Login()
        {
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=localhost,1433;database=register_translate;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //获取用户名
            string userName = this.txtUserName.Text;
            //获取密码
            string pwd = this.txtPwd.Text;
            if (Validation.checktxt(userName, "亲，用户名不能为空哦！", this.checkName))
            {
                MessageBox.Show(checkName.Text);
                return;
            }
            if (Validation.checktxt(pwd, "亲，密码不能为空哦！", this.checkPWD))
            {
                MessageBox.Show(checkPWD.Text);
                return;
            }
            //如果选中老师登录
            DataTable dt;
            if (this.radTeacher.Checked)
            {
                //老师登录后查询信息且有老师权限 
                User.power = "教师";
                dt = loin.teacherLogin("teacher", userName, pwd);
            }
            //如果选中学生登录
            else if (this.radStudent.Checked)
            {
                User.power = "学生";
                dt = loin.studentLogin(userName, pwd);

            }

            if (User.power == "学生")
            {
                //后面里面要加一点信息，先把老师和学生分开
                this.Hide();
                MessageBox.Show("欢迎亲爱的" + User.power + ":" + User.name + "！");
            }
            else if (User.power == "老师")
            {
                this.Hide();
                MessageBox.Show("欢迎亲爱的" + User.power + ":" + User.name + "！");

            }
            else
            {
                MessageBox.Show("账户或密码错误", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

    }
    
}
