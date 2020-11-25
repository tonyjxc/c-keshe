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

namespace frmWin.ClassInfo
{
    public partial class AddClass : Form
    {
        public string teacherid = "0";
        public AddClass()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select teachName from teacher", conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())
            {
                this.teacher.Items.Add(reader[0].ToString());
            }
            teacher.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }
        // 获取班级号
        public void getTeacherId()
        {
            string choosedName = teacher.Text;

            // 填充宿舍
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select teachId from teacher where teachName = '" + choosedName + "'", conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.teacherid = reader[0].ToString();
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int classnewid = 0;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select classId from classinfo", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                classnewid = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            classnewid++;
            string newname = this.classname.Text;

            getTeacherId();
            string memo = this.txtMemo.Text;
            string myinsert = "insert into classinfo(classid,fk_teachId,createDate,endDate,name,memo) values (" + classnewid+","+ teacherid + ",'"+ this.CreateTime.Value + "','"+ this.CreateTime.Value + "','"+newname+"','"+memo+"')";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            MessageBox.Show(teacher.Text+"老师的班级已经添加成功");
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
