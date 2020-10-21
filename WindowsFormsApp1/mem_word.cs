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
    public partial class mem_word : Form
    {
        public String temp;
        public int mamwordusignid = 0;
        public mem_word(int usingid)
        {
            this.mamwordusignid = usingid;
            InitializeComponent();

            

            //先建立连接
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=register_translate;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();

            //填充表格
            String str = "select word,answer from TRANSLATE_WORD where userid = " + mamwordusignid;
            SqlDataAdapter data = new SqlDataAdapter(str, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            table.DataSource = datatable;
            conn.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            //返回
            this.DialogResult = DialogResult.Abort;
            this.Dispose();
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            //退出
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
            this.Close();
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //因为可能点到了不能点的地方，所以要catch然后什么都不做
            try
            {
                //单击后单词消失，同时弹出一个对话框来默写
                temp = table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                String question = null;

                //如果是右边，则question是左边
                if (e.ColumnIndex == 1)
                    question = table.Rows[e.RowIndex].Cells[0].Value.ToString();
                else
                    question = table.Rows[e.RowIndex].Cells[1].Value.ToString();

                //MessageBox.Show(question);
                inputbox input = new inputbox(question);
                input.ShowDialog();
                String spell = input.inputthings;
                if (spell == temp)
                {
                    MessageBox.Show("恭喜你，拼对啦！！");
                }
                else
                {
                    MessageBox.Show("很遗憾，拼错了，重新再看一看吧。");
                }

                table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = temp;
            }
            catch (Exception)
            { }
        }
    }
}
