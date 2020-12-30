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

namespace frmWin.Student
{
    public partial class WhatsStuName : Form
    {
        public MyGlobal jumpinfo;
        public string teacherId;
        public string classId;
        public WhatsStuName(MyGlobal jumpinfo2)
        {
            this.jumpinfo = jumpinfo2;
            InitializeComponent();
            initshow();

        }

        public void initshow()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select teachName from teacher", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.chooseteacher.Items.Add(reader[0].ToString());
            }
            chooseteacher.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findstu()
        {
            this.stufullname.Text = "";
            this.stufullname.Items.Clear();
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select stuName from student,classinfo,teacher where fk_classId = classId and teachId = fk_teachId and teachName = '" + chooseteacher.Text + "' and  stuName like '" + stuname.Text + "%' and  stuNum like '" + enteryear.Text + "%'", conn);
            if (stuname.Text == "" || enteryear.Text == "")
            {
                if (stuname.Text == "" && enteryear.Text == "")
                {
                    sql = new SqlCommand("select stuName from student,classinfo,teacher where fk_classId = classId and teachId = fk_teachId and teachName = '" + chooseteacher.Text + "'", conn);
                }
                else if (stuname.Text != "")
                {
                    sql = new SqlCommand("select stuName from student,classinfo,teacher where fk_classId = classId and teachId = fk_teachId and teachName = '" + chooseteacher.Text + "' and  stuName like '" + stuname.Text + "%'", conn);
                }
                else
                {
                    sql = new SqlCommand("select stuName from student,classinfo,teacher where fk_classId = classId and teachId = fk_teachId and teachName = '" + chooseteacher.Text + "' and  stuNum like '" + enteryear.Text + "%'", conn);
                }
            }
            SqlDataReader reader = sql.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("抱歉，未找到任何同学。");
                return;
            }
            else
            {
                this.stufullname.Items.Add(reader[0].ToString());
                while (reader.Read())
                {
                    this.stufullname.Items.Add(reader[0].ToString());
                }
            }


            //stufullname.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
            if (stufullname.Items.Count > 0)
            {
                stufullname.SelectedIndex = 0;
            }
            if (stufullname.Items.Count == 1)
            {
                MessageBox.Show("匹配到一个学生！您要找的应该是：" + stufullname.Text);
            }

        }
        private void submit_Click(object sender, EventArgs e)
        {
            findstu();
        }

        private void stuname_TextChanged(object sender, EventArgs e)
        {
            //findstu();
        }

        private void enteryear_TextChanged(object sender, EventArgs e)
        {
            findstu();
        }

    }
}
