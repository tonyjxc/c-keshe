﻿using System;
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
        public MyGlobal jumpinfo;
        // 教师登录的信息
        public string fk_teacherid = "2";
        public string classId;
        public FrmClass(MyGlobal jumpinfo2)
        {
            this.jumpinfo = jumpinfo2;
            if (jumpinfo.user == "student")
            {
                MessageBox.Show("请用教师身份登录");
                this.Size = new Size(500, 0);
                return;
            }
            this.fk_teacherid = jumpinfo.teachId;
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

            int flag = 0;

            // 验证classId
            SqlCommand sql = new SqlCommand("select stuId from student where fk_classId = " + classId, conn);

            SqlDataReader reader = sql.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("该班级没有学生，可以直接删除！");
            }
            else
            {
                MessageBox.Show("该班级还有学生，已将学生放入待定班级！");
                flag = 1;
            }
            reader.Close();

            // 此时需要将学生移入待定班级
            if (flag == 1)
            {
                string mychange = "update student set fk_classId =-1 where fk_classId = " + classId;
                SqlCommand change = new SqlCommand(mychange, conn);               //定义OleDbCommnad对象并连接数据库             
                change.ExecuteNonQuery();
            }
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
