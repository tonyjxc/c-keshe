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

    public partial class NoClassStuFrm : Form
    {
        public string classId = "";
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

        public void ShowStu()
        {
            NoclassStu.DataSource = null;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //定义查询的sql语句
            string sqlquery = @"select
                                  stuId,stuNum,stuName from student
                                  where fk_classId = -1";

            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            NoclassStu.DataSource = datatable;
            conn.Close();
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

        public NoClassStuFrm()
        {
            InitializeComponent();
            LoadClassInfo();
            //加载宿舍楼
            ShowStu();
        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            getClassId();
            string myinsert = "update student set fk_classId=" + classId + " where fk_classId = -1";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            conn.Close();
        }
    }
}
