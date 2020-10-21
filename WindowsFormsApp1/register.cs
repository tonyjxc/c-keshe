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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user_name = username_txtbox.Text;
            String user_sercret1 = usersecret_txtbox2.Text;
            String user_sercret2 = usersecret_txtbox1.Text;

            //注册功能
            //判断密码
            if (user_sercret1 != user_sercret2)
            {
                MessageBox.Show("您两次，密码输入不一致，请确认后重新输入！");
                return;
            }

            //远程ip会变的
            //连接数据库
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=register_translate;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();

            //判断是否重复
            SqlCommand cmd = new SqlCommand("SELECT * FROM TRANSLATE_USER where user_name='" + user_name + "'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            //用户名相同
            if (sdr.HasRows)
            {
                MessageBox.Show("该用户名已注册，请更换用户名或直接登录。");
                sdr.Close();
                conn.Close();
                return;
            }

            //用户名可用，存储
            else
            {
                sdr.Close();
                
                //需要获取下一个用户的userid
                SqlCommand findidcmd = new SqlCommand("select max(userid) from TRANSLATE_USER",conn);
                int userid=0;
                SqlDataReader idreader = findidcmd.ExecuteReader();
                if (idreader.Read())
                    userid = idreader.GetInt32(0)+1;    //获取最大id后+1
                else
                    MessageBox.Show("在数据保存至数据库时出错");                
                idreader.Close();

                string myinsert = "insert into TRANSLATE_USER(user_name,user_secret,userid) values ('" + username_txtbox.Text + "','" + usersecret_txtbox2.Text + "','"+userid+"')";
                SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
                mycom.ExecuteNonQuery();                                         //执行插入语句 



                //关闭数据库
                //关闭数据库
                conn.Close();
                //结束这个form
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                this.Close();
            }
        }



        private void logout_Click(object sender, EventArgs e)
        {
            //退出
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
            this.Close();
        }

        private void return_but_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Dispose();
            this.Close();
        }
    }
}
