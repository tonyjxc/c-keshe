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

namespace frmWin.teacher
{
    public partial class ChangeTeachInfo : Form
    {
        public Boolean canupdate =true;
        public string oldsex;
        public string oldphone;
        public string teachid;
        public MyGlobal jumpinfo;
        public string oldteachnum;
        public ChangeTeachInfo(MyGlobal jumpinfo2)
        {
            this.jumpinfo = jumpinfo2;
            if (this.jumpinfo.user == "student")
            {
                MessageBox.Show("请用教师身份登录");
                this.Size = new Size(500, 0);
                return;
            }
            this.teachid = jumpinfo.teachId;
            InitializeComponent();
            Initdisp();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (canupdate == false)
            {
                MessageBox.Show("请将红色的信息正确填写");
                return;
            }
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string newnum = this.teachnum.Text;
            string newname = this.name.Text;
            string newsex = this.sex.Text;
            string newtelnum = this.telnum.Text;
            string newcreatetime = this.CreateTime.Value.ToString();
            string newspecialty = this.specialty.Text;
            string myinsert = "update teacher set teachUserName = '" + newnum + "',teachName='" + newname + "',sex='" + newsex + "',tel='" + newtelnum + "',hireDate='" + newcreatetime + "',specialty='" + newspecialty + "'where teachId = " + teachid;
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("教师信息已更新完毕");
            this.Close();
        }

        public Boolean teachnumcheck()
        {
            if (teachnum.Text == this.oldteachnum)
                return true;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            // 验证classId
            SqlCommand sql = new SqlCommand("select teachUserName from teacher where teachUserName = '" + this.teachnum.Text + "'", conn);

            SqlDataReader reader = sql.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("该编号可用！");
                reader.Close();
                conn.Close();
                return true;
            }
            else
            {
                MessageBox.Show("该编号不可用！更新信息失败！");
                reader.Close();
                conn.Close();
                return false;
            }
            return false;
        }

        public void Initdisp()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select teachUserName,teachName,sex,tel,hireDate,specialty from teacher where teachId = " + teachid, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.teachnum.Text = reader[0].ToString();
            this.name.Text = reader[1].ToString();
            this.sex.Text = reader[2].ToString();
            oldsex = this.sex.Text;
            this.telnum.Text = reader[3].ToString();
            oldphone = this.telnum.Text;
            this.CreateTime.Text = reader[4].ToString();
            this.specialty.Text = reader[5].ToString();
            conn.Close();
            reader.Close();
            this.oldteachnum = this.teachnum.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sex_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string myinsert = "update teacher set sex = '"+this.sex.Text +"' where teachId = '"+jumpinfo.teachId+"'";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            int temp = 1;
            try
            {
                mycom.ExecuteNonQuery();
            }
            catch (Exception except)
            {
                temp = 0;


            }
            finally
            {
                myinsert = "update teacher set sex = '" + this.oldsex + "' where teachId = '" + jumpinfo.teachId + "'";
            }
            if (temp == 0)
            {
                wrongtips.Text = "性别必须为男或女";
                this.sex.ForeColor = Color.Red;
                canupdate = false;
            }
            else
            {
                wrongtips.Text = "";
                this.sex.ForeColor = Color.Black;
                canupdate = true;
            }
            conn.Close(); 
        }

        private void telnum_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string myinsert = "update teacher set tel = '" + this.telnum.Text + "' where teachId = '" + jumpinfo.teachId + "'";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            int temp = 1;
            try
            {
                mycom.ExecuteNonQuery();
            }
            catch (Exception except)
            {
                temp = 0;         
            }
            finally
            {
                myinsert = "update teacher set tel = '" + this.oldphone+ "' where teachId = '" + jumpinfo.teachId + "'";
            }
            if (temp == 0)
            {
                wrongtips.Text = "电话必须为5位数字！";
                this.telnum.ForeColor = Color.Red;
                canupdate = false;
            }
            else
            {
                wrongtips.Text = "";
                this.telnum.ForeColor = Color.Black;
                canupdate = true;
            }
            conn.Close();
        }
    }
}
