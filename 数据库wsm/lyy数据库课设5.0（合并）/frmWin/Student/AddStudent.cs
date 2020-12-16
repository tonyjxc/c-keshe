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
            string mysex = "";
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //数据库语句：select typeName,personcount,price,sex,memo from dormtype where typeName='四人间（男）'
            //select typeName,personcount,price,sex,memo from dormtype where typeName='"+ChangedormtypeName+"'";
            string myinsert = @"select teachId,teachName,teachUserName,teachPass,sex from teacher where teachId='" + ChangedormtypeName + "'";
            SqlCommand sql = new SqlCommand(myinsert, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            txtteachId.Text = reader[0].ToString();
            txtteachName.Text = reader[1].ToString();
            txtteachUserName.Text = reader[2].ToString();
            txtteachPass.Text = reader[3].ToString();
        }
    }
}
