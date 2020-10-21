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
    public partial class translate_or_memory : Form
    {
        public int times = 0;
        public translate_or_memory(ref int usingid,int firstin)
        {
            //先建立连接
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=register_translate;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            if (firstin == 1)
            {
                //修改登陆次数  
                SqlCommand cmd = new SqlCommand("SELECT times FROM TRANSLATE_USERTIMES where userid=" + usingid, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    times = sdr.GetInt32(0) + 1;
                    sdr.Close();
                    string myinsert = "update TRANSLATE_USERTIMES set times=" + times + " where userid = " + usingid;
                    SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
                    mycom.ExecuteNonQuery();                                         //执行插入语句 
                }
                else
                {
                    MessageBox.Show("欢迎您第一次使用本翻译软件");
                    sdr.Close();
                    string myinsert = "insert into TRANSLATE_USERTIMES(userid,times) values (" + usingid + ",1)";
                    SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
                    mycom.ExecuteNonQuery();                                         //执行插入语句 
                    times = 1;
                }
            }
            else if(firstin==0)
            {
                SqlCommand cmd = new SqlCommand("SELECT times FROM TRANSLATE_USERTIMES where userid=" + usingid, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    //获取登陆的次数
                    times = sdr.GetInt32(0);
                    sdr.Close();
                }
            }
            conn.Close();
            InitializeComponent();
            this.sayhello.Text = "欢迎您第" + times + "次使用本翻译软件，请您选择需要的功能";
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            //退出
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
            this.Close();
        }

        private void memory_but_Click(object sender, EventArgs e)
        {
            //背诵
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();
        }

        private void translate_but_Click(object sender, EventArgs e)
        {
            //翻译
            this.DialogResult = DialogResult.Yes;
            this.Dispose();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            //返回
            this.DialogResult = DialogResult.Abort;
            this.Dispose();
            this.Close();
        }
    }
}
