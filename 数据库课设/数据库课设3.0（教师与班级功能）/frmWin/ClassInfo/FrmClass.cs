using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using keshe;
using System.Runtime.CompilerServices;
using frmWin.fun;

namespace frmWin
{
    public partial class FrmClass : Form
    {
        // 教师登录的信息
        public string fk_teacherid = "2";
        public string classId;
        public FrmClass()
        {
            InitializeComponent();
        }


        // 获取班级号
        public void getClassId()
        {
            string choosedName = ClassType.Text;

            // 填充宿舍
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select classId from classinfo where name = '"+ choosedName+"'", conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.classId = reader[0].ToString();
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }


        public void ShowClass()
        {
            ClassInfo.DataSource = null;
            getClassId();
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //定义查询的sql语句
            string sqlquery = @"select
                                  stuId,stuNum,stuName from student
                                  where fk_classId = {0}";
         
            sqlquery = string.Format(sqlquery, classId);

            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            ClassInfo.DataSource = datatable;
            conn.Close();
        }

        public void LoadClassInfo()
        {
            this.ClassType.Items.Clear();
            // 填充宿舍
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();            
            SqlCommand sql = new SqlCommand("select name from classinfo where fk_teachId = "+fk_teacherid, conn);
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
        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                //加载宿舍类型
                LoadClassInfo();
                //加载宿舍楼
                ShowClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错了" + ex.Message);
            }
        }

        private void ClassInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ClassType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 更改则更新显示
            ShowClass();
        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string delname = ClassType.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            getClassId();
            string myinsert = "delete from classinfo where classid = "+classId;
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库             
            mycom.ExecuteNonQuery();
            conn.Close();
            //加载宿舍类型
            LoadClassInfo();
            //加载宿舍楼
            ShowClass();
            MessageBox.Show(delname + "班级已经成功删除");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
