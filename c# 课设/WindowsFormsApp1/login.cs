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

namespace WindowsFormsApp1
{

    public partial class Login : Form
    {

        public int login_usingid;
        public Login()
        {
            InitializeComponent();
        }

        //注册按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //无操作，跳转注册
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();      
        }


        
        //登陆按钮
        private void button2_Click(object sender, EventArgs e)
        {
            //判断密码
            //正确
            //错误
            //远程ip会变的
            SqlConnection conn = new SqlConnection("server="+MyGlobal.ip+";database=register_translate;UID=sa;PWD=zyh@197068;Integrated Security=False");

            conn.Open();

            String user_name =username_txtbox.Text;
            String user_sercret =userid_txtbox.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM TRANSLATE_USER where user_name='"+ user_name+ "' and user_secret='"+user_sercret+"'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();

            //登录成功
            if (sdr.HasRows)
            {
                sdr.Close();
                //获取登陆的用户
                SqlCommand findidcmd = new SqlCommand("select userid from TRANSLATE_USER where user_name='"+user_name+"'", conn);
                this.login_usingid = -6;
                SqlDataReader idreader = findidcmd.ExecuteReader();
                if (idreader.Read())
                {
                    this.login_usingid = idreader.GetInt32(0);    //获取正在使用的用户id
                    //MessageBox.Show(Convert.ToString(this.login_usingid));
                }
                else
                    MessageBox.Show("在查询用户userid时出错");
                idreader.Close();

                //结束这个form
                //跳转功能界面
                //返回yes，进入使用翻译的界面
                conn.Close();
                this.DialogResult = DialogResult.Yes;
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新注册或登录");
                return;
            }
           
        }


        //退出按钮
        private void logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
            this.Close();
        }
    }
}
