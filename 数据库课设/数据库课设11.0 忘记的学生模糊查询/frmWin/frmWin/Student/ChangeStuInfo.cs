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
    public partial class ChangeStuInfo : Form
    {
        
        public void Initdisp()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select stuNum,stuName,sex,tel,inDate,city from student where stuId = " + stuId, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.teachnum.Text = reader[0].ToString();
            this.name.Text = reader[1].ToString();
            this.sex.Text = reader[2].ToString();
            this.telnum.Text = reader[3].ToString();
            this.CreateTime.Text = reader[4].ToString();
            this.city.Text = reader[5].ToString();
            conn.Close();
            reader.Close();
        }
        public string stuNum;
        public string stuId;
        public MyGlobal jumpinfo;
        public ChangeStuInfo(MyGlobal jumpinfo2)
        {
            this.jumpinfo = jumpinfo2;
            if (this.jumpinfo.user == "teacher")
            {
                MessageBox.Show("请用学生身份登录");
                this.Size = new Size(500, 0);
                return;
            }
            InitializeComponent();
            this.stuId = jumpinfo.stuId;
            Initdisp();
            this.stuNum = this.teachnum.Text;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!stunumcheck())
                return;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string newnum = this.teachnum.Text;
            string newname = this.name.Text;
            string newsex = this.sex.Text;
            string newtelnum = this.telnum.Text;
            string newcreatetime = this.CreateTime.Value.ToString();
            string newcity= this.city.Text;
            string myinsert = "update student set stuNum = '" + newnum +"',stuName='"+newname+"',sex='"+newsex+"',tel='"+newtelnum+"',inDate='"+newcreatetime+"',city='"+newcity+"'where stuId = "+stuId;
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("学生信息已更新完毕");
            this.Close();
        }

        public Boolean stunumcheck()
        {
            if (teachnum.Text == stuNum)
                return true;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            // 验证classId
            SqlCommand sql = new SqlCommand("select stuNum from student where stuNum = '"+this.teachnum.Text+"'", conn);

            SqlDataReader reader = sql.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("该学号可用！");
                reader.Close();
                conn.Close();
                return true;
            }
            else
            {
                MessageBox.Show("该学号不可用！学生更新信息失败！");
                reader.Close();
                conn.Close();
                return false;
            }
            return false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
