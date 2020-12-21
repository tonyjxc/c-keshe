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
    public partial class stuenterdorm : Form
    {
        public Boolean firsttime;
        public string teacherId;
        public string classId;
        public string stuId;
        public string dormtypeId;
        public string buildId;
        public string dormId;
        public MyGlobal jumpinfo;
        public stuenterdorm(MyGlobal jumpinfo2)
        {
            firsttime = true;
            this.jumpinfo = jumpinfo2;
            if (jumpinfo.user != "teacher")
            {
                MessageBox.Show("请用教师身份登录");
                this.Size = new Size(500, 0);
                return;
            }
            InitializeComponent();
            initshow();
        }
        public void initshow()
        {
            showteacher();

        }

        public void showteacher()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select teachName from teacher", conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())
            {
                this.chooseteacher.Items.Add(reader[0].ToString());
            }
            chooseteacher.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
            getteacherid();

        }

        public void showdormtype()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select typeName from dormtype ", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.dormtype.Items.Add(reader[0].ToString());
            }
            dormtype.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }


        private void chooseteacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            getteacherid();
            if (!firsttime)
                showclassinfo();
            firsttime = false;
        }

        public void showclassinfo()
        {
            this.chooseclass.Text = "";
            this.chooseclass.Items.Clear();
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            // SqlCommand sql = new SqlCommand("select name from classinfo where fk_teachId = " +teacherId, conn);
            SqlCommand sql = new SqlCommand("select name from classinfo,teacher where fk_teachId = teachId and teachName = '"+ chooseteacher.Text+"'", conn);

            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.chooseclass.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            if (chooseclass.Items.Count > 0)
            {
                chooseclass.SelectedIndex = 0;
            }

        }
        public void getteacherid()
        {
            string choosedName = chooseteacher.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select teachId from teacher where teachname = '" + choosedName + "'", conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.teacherId = reader[0].ToString();
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();

        }
        public void getClassId()
        {
            string choosedName = chooseclass.Text;
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

        public void getStuId()
        {
            string choosedName = choosestudent.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select stuId from student where stuName = '" + choosedName + "'", conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.stuId = reader[0].ToString();
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }

        private void chooseclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            getClassId();
            loadstu();
        }

        private void loadstu()
        {
            this.choosestudent.Text="";
            this.choosestudent.Items.Clear();
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select stuName from student,classinfo,teacher where fk_classId=classId and name = '" + chooseclass.Text + "' and fk_teachId = teachId and teachName = '" + chooseteacher.Text + "'", conn);

            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.choosestudent.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            if (choosestudent.Items.Count > 0)
            {
                choosestudent.SelectedIndex = 0;
            }
        }

        private void choosestudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            getStuId();
            setsex();
            loaddormtype();
        }

        private void building_SelectedIndexChanged(object sender, EventArgs e)
        {
            getbuildId();
            remianlabel.Text="0";
            setdormremain();
            loaddormname();
        }
        private void dormtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            getdormtypeId();
            loadbuilding();
        }

        public void getdormtypeId()
        {
            string choosedName = dormtype.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select typeId from dormtype where typeName = '" + choosedName + "'", conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.dormtypeId = reader[0].ToString();
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }
        public void getbuildId()
        {
            string choosedName = building.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select buildId from building where buildName = '" + choosedName + "'", conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.buildId = reader[0].ToString();
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }

        public void getdormId()
        {
            string choosedName = dormnum.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select dormId from dorm where dormNum = '" + choosedName + "'", conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.dormId = reader[0].ToString();
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }

        public void setdormremain()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select dormCount from building where buildId = " + buildId, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            int dormCount = int.Parse( reader[0].ToString());
            //设置id值属性和文本属性
            reader.Close();

            sql = new SqlCommand("select dormId from dorm where fk_buildId = " + buildId, conn);
            reader = sql.ExecuteReader();
            int used = 0;
            while (reader.Read())
            {
                used++;
            }
        
            int remain = dormCount-used;
            dormremainlabel.Text = remain.ToString();
            reader.Close();
            conn.Close();

        }

        public void loadbuilding()
        {
            this.building.Text = "";
            this.building.Items.Clear();
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select buildName from building where sex = '" + sexlabel.Text + "'", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.building.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            if (building.Items.Count > 0)
            {
                building.SelectedIndex = 0;
            }

        }

        private void loaddormtype()
        {
            this.dormtype.Text = "";
            this.dormtype.Items.Clear();
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select typeName from dormtype where sex = '"+sexlabel.Text+"'",conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.dormtype.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            if (dormtype.Items.Count > 0)
            {
                dormtype.SelectedIndex = 0;
            }
        }

        private void setsex()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select sex from student where stuId = " + stuId , conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            string sex = reader[0].ToString();
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
            MessageBox.Show(sex);
            sexlabel.Text = sex;
        }

        public void loaddormname()
        {
            this.dormnum.Text = "";
            this.dormnum.Items.Clear();
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            // SqlCommand sql = new SqlCommand("select dormnum from dorm where fk_buildId = '" + buildId + "' and fk_typeId = '"+dormtypeId+"'", conn);
            SqlCommand sql = new SqlCommand("select dormnum from dorm,building,dormtype where fk_buildId = buildId and fk_typeId = typeId and buildName = '"+ building.Text+"' and typeName = '"+ dormtype.Text +"'", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.dormnum.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            if (dormnum.Items.Count > 0)
            {
                dormnum.SelectedIndex = 0;
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string olddormId="no";
            // 判断剩余数和自己是不是在0的寝室
            if (remianlabel.Text == "0")
            {
                SqlCommand sql = new SqlCommand("select stuId from student where fk_dormId ='" + dormId + "' and stuId = " + stuId, conn);
                SqlDataReader reader = sql.ExecuteReader();
                // 如果不在
                if (!reader.Read())
                {
                    MessageBox.Show("该寝室已经满了，本同学不在，故不能添加！！");
                }
                else
                {
                    MessageBox.Show("该寝室已经满了，本同学本身处于该寝室！");
                }
                reader.Close();
                return;
            }
            else
            {
                SqlCommand sql = new SqlCommand("select fk_dormId from student where fk_dormId ='" + dormId + "' and stuId = " + stuId, conn);
                SqlDataReader reader = sql.ExecuteReader();
                // 如果不在
                if (!reader.Read())
                {
                    MessageBox.Show("该寝室没有满，本同学不在，可以添加！！");
                }
                else
                {
                    MessageBox.Show("该寝室没有满，本同学本身处于该寝室！");
                    reader.Close();
                    return;
                }
                reader.Close();

                sql = new SqlCommand("select fk_dormId from student where stuId = " + stuId, conn);
                reader = sql.ExecuteReader();
                // 如果不在
                if (!reader.Read())
                {
                    olddormId = "no";
                }
                else
                {
                    olddormId = reader[0].ToString();
                }
                reader.Close();

                // 修改学生宿舍号
                string mychange = "update student set fk_dormId =" + dormId + " where stuId = " + stuId;
                SqlCommand change = new SqlCommand(mychange, conn);               //定义OleDbCommnad对象并连接数据库             
                change.ExecuteNonQuery();


                // 添加宿舍count 和 删除 count
                // 统计已经有的学生数量
                sql = new SqlCommand("select personCount from dormtype where typeId = " + dormtypeId, conn);
                reader = sql.ExecuteReader();
                reader.Read();
                int dormCount = int.Parse(reader[0].ToString());
                reader.Close();

                sql = new SqlCommand("SELECT count(*) FROM student,dorm where fk_dormId = dormId and dormNum = '" + dormnum.Text + "'", conn);
                reader = sql.ExecuteReader();
                reader.Read();
                int used = int.Parse(reader[0].ToString());
                reader.Close();
                remianlabel.Text = (dormCount - used).ToString();

                //修改新的
                mychange = "update dorm set personCount =" + used + " where dormId = " + dormId;
                change = new SqlCommand(mychange, conn);               //定义OleDbCommnad对象并连接数据库             
                change.ExecuteNonQuery();

                // 修改旧的
                if (string.Equals(olddormId, "no"))
                {
                    sql = new SqlCommand("SELECT count(*) FROM student where fk_dormId = " + olddormId, conn);
                    reader = sql.ExecuteReader();
                    reader.Read();
                    used = int.Parse(reader[0].ToString());
                    MessageBox.Show(used.ToString());
                    reader.Close();
                    mychange = "update dorm set personCount =" + used + " where dormId = " + olddormId;
                    change = new SqlCommand(mychange, conn);               //定义OleDbCommnad对象并连接数据库             
                    change.ExecuteNonQuery();
                }


            }

        }

        private void dormnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            getdormId();
            setremain();
        }

        public void setremain()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select personCount from dormtype where typeId = " + dormtypeId, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            int dormCount = int.Parse(reader[0].ToString());
            reader.Close();

            sql = new SqlCommand("SELECT count(*) FROM student,dorm where fk_dormId = dormId and dormNum = '"+ dormnum.Text +"'" ,conn);
            reader = sql.ExecuteReader();
            reader.Read();
            int used = int.Parse(reader[0].ToString());
            /*
            sql = new SqlCommand("select stuId from student where fk_dormId = " + dormId, conn);
            reader = sql.ExecuteReader();
            int used = 0;

            while (reader.Read())
            {
                used++;
            }
            */
            int remain = dormCount - used;
            remianlabel.Text = remain.ToString();
            reader.Close();
            conn.Close();
        }
    }
}
