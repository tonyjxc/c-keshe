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
    public partial class AddStudent : Form
    {
        public MyGlobal jumpinfo;
        public string classId;
        public AddStudent(MyGlobal jumpinfo2)
        {
            this.jumpinfo = jumpinfo2;
            if (jumpinfo.user != "teacher")
            {
                MessageBox.Show("请用教师身份登录");
                this.Size = new Size(500, 0);
                return;
            }
            InitializeComponent();
            initinfo();
        }

        public void initinfo()
        {
            LoadClassInfo();
        }

        public void LoadClassInfo()
        {
            this.ClassType.Items.Clear();
            // 填充宿舍
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select name from classinfo", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.ClassType.Items.Add(reader[0].ToString());
            }
            ClassType.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }

        public void getClassId()
        {
            string choosedName = ClassType.Text;

            // 填充宿舍
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select classId from classinfo where name = '" + choosedName + "'", conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.classId = reader[0].ToString();
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //数据库语句：select typeName,personcount,price,sex,memo from dormtype where typeName='四人间（男）'
            //select typeName,personcount,price,sex,memo from dormtype where typeName='"+ChangedormtypeName+"'";
            string addstuname = studentname.Text;
            int stunewid = 0;
            SqlCommand sql = new SqlCommand("select stuId from student", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                stunewid = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            stunewid++;
            getClassId();
            string myinsert = "insert into student(stuId,stuName,stuUserName,stuPass,fk_classId,tel,city,memo) values ("+stunewid+", '"+studentname.Text+ "','" + stunewid + "','" + stunewid + "',"+classId+",'"+phonenum.Text+"','"+city.Text+"','"+txtMemo.Text+"')";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            MessageBox.Show(studentname.Text + "学生已经添加成功");
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
