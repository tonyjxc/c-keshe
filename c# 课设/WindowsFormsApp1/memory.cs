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
    public partial class memory : Form
    {
        public int mem_usingid=0;
        public memory(ref int usingid)
        {
            this.mem_usingid = usingid;
            //先建立连接
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=register_translate;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();

            int times = 0;

            //获取登陆次数  
            SqlCommand cmd = new SqlCommand("SELECT times FROM TRANSLATE_USERTIMES where userid=" + usingid, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                //获取登陆的次数
                times = sdr.GetInt32(0);
                sdr.Close();
            }
            conn.Close();
            InitializeComponent();
            this.sayhello.Text = "欢迎您第" + times + "次使用本翻译软件，请选择您需要的功能";
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
            this.Close();
        }

        private void sentenc_but_Click(object sender, EventArgs e)
        {
            //句子
            this.DialogResult = DialogResult.Yes;
            this.Dispose();
            this.Close();

        }

        private void word_but_Click(object sender, EventArgs e)
        {
            //单词
            this.DialogResult = DialogResult.Abort;
            this.Dispose();
            this.Close();
        }
    }
}
