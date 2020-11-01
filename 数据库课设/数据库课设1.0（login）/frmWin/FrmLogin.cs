using frmWin.fun;
using keshe;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //获取用户名
            string userName = this.textBox1.Text.ToString();
            //获取密码
            string pwd = this.textBox2.Text.ToString();
            string reply = "亲，用户名不能为空哦！";
            if (Validation.checktxt(userName, ref reply))
            {
                MessageBox.Show(reply);
                return;
            }
            reply = "亲，密码不能为空哦！";
            if (Validation.checktxt(pwd, ref reply))
            {
                MessageBox.Show(reply);
                return;
            }


            //如果选中老师登录
            DataTable dt;
            if (this.radTeacher.Checked)
            {
                //老师登录后查询信息且有老师权限 
                User.power = "教师";
                dt = loin.teacherLogin(userName, pwd);
            }
            //如果选中学生登录
            else if (this.radStudent.Checked)
            {
                User.power = "学生";
                dt = loin.studentLogin(userName, pwd);

            }
            else
            {
                MessageBox.Show("请选择您的登陆身份！");
                return;
            }

            // MessageBox.Show(( dt.Columns.Count).ToString());
            if (dt.Columns.Count != 0)
            {
                if (User.power == "学生")
                {
                    //后面里面要加一点信息，先把老师和学生分开
                    this.Hide();
                    MessageBox.Show("欢迎亲爱的" + User.power + ":" + User.name + "！");
                }
                else if (User.power == "教师")
                {
                    this.Hide();
                    MessageBox.Show("欢迎亲爱的" + User.power + ":" + User.name + "！");

                }
            }
            else
            {
                MessageBox.Show("账户或密码错误", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            // 暂时结束
            MessageBox.Show("登陆界面已经完成");
            
            this.Dispose();
            this.Close();

        }

    }

}
