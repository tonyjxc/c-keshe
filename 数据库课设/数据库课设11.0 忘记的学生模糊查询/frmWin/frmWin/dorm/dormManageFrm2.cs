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
using frmWin.fun;

namespace frmWin.dorm
{
    public partial class dormManageFrm2 : Form
    {
        public MyGlobal jumpinfo;
        public static bool sign = false;
        public dormManageFrm2(MyGlobal jumpinfo2)
        {
            this.jumpinfo = jumpinfo2;
            if (this.jumpinfo.user == "student")
            {
                MessageBox.Show("请用教师身份登录");
                this.Size = new Size(500, 0);
                return;
            }
            InitializeComponent();
            LoadDormName();
            LoadBuildName();
            LoadDormInfoFirst();
            UpdateInfo();
            Updateflag2();

        }
        public void LoadDormName()
        {
            // this.txtDromName.Items.Clear();
            // 填充宿舍
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select dormNum from dorm ", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.txtDormName.Items.Add(reader[0].ToString());
            }
            txtDormName.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }
        public void LoadBuildName() 
        {
            // this.txtDromName.Items.Clear();
            // 填充宿舍
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select buildName from building ", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.txtBuildName.Items.Add(reader[0].ToString());
            }
            txtBuildName.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }
        public void LoadDormInfoFirst()
        {
            dgvDorm.DataSource = null;
            string DormName = txtDormName.Text;
            string BuildName = txtBuildName.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //定义查询的sql语句  select buildName,dormNum,personCount from dorm,building where buildId=fk_buildid
            string sqlquery = @"select distinct buildName,dormNum,personCount,flag1 from dorm,building where buildId=fk_buildid";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDorm.DataSource = datatable;
            conn.Close();
        }
        public void LoadDormInfo()
        {
            dgvDorm.DataSource = null;
            string DormName = txtDormName.Text;
            string BuildName = txtBuildName.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //定义查询的sql语句  select buildName,dormNum,personCount from dorm,building where buildNum ='" + DormName + "' and dormNum='"+BuildName+" '";
            string sqlquery = @"select buildName,dormNum,personCount,flag from dorm,building where dormNum ='" + DormName + "' and buildName='" + BuildName + "'";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDorm.DataSource = datatable;
            conn.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string DormName = txtDormName.Text;
            string BuildName = txtBuildName.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select fk_buildid from dorm where dormNum =666 
            string sqlquery = @"select fk_buildid from dorm where dormNum ='" + DormName + "' ";
            SqlCommand mycom = new SqlCommand(sqlquery, conn);
            SqlDataReader reader = mycom.ExecuteReader();
            reader.Read();
            string buildid = reader[0].ToString();
            if (dormUpdateFrm2.sign == false)
            {
                
                dormUpdateFrm2 duf = new dormUpdateFrm2(DormName, BuildName, buildid);
                duf.Show();
                dormUpdateFrm2.sign = true;
            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadDormInfo();
        }

        private void dormManageFrm2_MdiChildActivate(object sender, EventArgs e)
        {
             
        }

        private void dormManageFrm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (dormInsertFrm2.sign == false)
            {
                dormInsertFrm2 f = new dormInsertFrm2();
                //f.MdiParent = this;
                dormInsertFrm2.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            string DormName = txtDormName.Text;
            string BuildName = txtBuildName.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select fk_buildid from dorm where dormNum =666 
            string sqlquery = @"select fk_buildid from dorm where dormNum ='" + DormName + "' ";
            SqlCommand mycom = new SqlCommand(sqlquery, conn);
            SqlDataReader reader = mycom.ExecuteReader();
            reader.Read();
            string buildid = reader[0].ToString();
            reader.Close();

            SqlConnection conn2 = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn2.Open();
            //select fk_typeId from dorm where dormNum=613 and fk_buildid=2
            //select fk_typeId from dorm where dormNum='" + DormName + "'and fk_buildid='"+buildid+"'";
            string sqlquery2 = @"select fk_typeId from dorm where dormNum='" + DormName + "'and fk_buildid='" + buildid + "'";
            SqlCommand mycom2 = new SqlCommand(sqlquery2, conn2);
            SqlDataReader reader2 = mycom2.ExecuteReader();
            reader2.Read();
            string typeid = reader2[0].ToString();
            reader2.Close();

            if (dormViewFrm2.sign == false)
            {

                dormViewFrm2 duf = new dormViewFrm2(DormName, BuildName, buildid, typeid);
                duf.Show();
                dormViewFrm2.sign = true;
            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }

        private void dormManageFrm2_Load(object sender, EventArgs e)
        {

        }

        private void btnFindStu_Click(object sender, EventArgs e)
        {
            string stuName = txtStuName.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select stuName,buildName,dormNum,personCount,flag from (dorm left join building on dorm.fk_buildid=buildId)
            //left join student on student.fk_dormId=dormId
            //where stuName like '王%'
            //%stuName%
            string sqlquery = @"select stuName,buildName,dormNum,personCount,flag from (dorm left join building on dorm.fk_buildid=buildId)left join student on student.fk_dormId=dormId where stuName like '%" + stuName+"%'";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDorm.DataSource = datatable;
            conn.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dormCredit.sign == false)
            {
                dormCredit f = new dormCredit();
                dormCredit.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }
        public void UpdateInfo()
        {
            
            //每次进入这个界面都会实时更新宿舍信息
            int dormid = 0;
            int value1 = 0;
            string value2 = "";
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string sqlquery = @"select dormId,personCount,flag1 from dorm";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            int rowCount = datatable.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                value1 = (int)datatable.Rows[i].ItemArray[1];//personcount
                value2 = (string)datatable.Rows[i].ItemArray[2];//是否可入住的信息
                //MessageBox.Show(value2);
                if (value1 < 4&& value2=="不可入住")
                {
                    dormid = (int)datatable.Rows[i].ItemArray[0];
                    //update dorm set flag1='可入住' where dormId=5
                    string sqlquery1 = @"update dorm set flag1='可入住' where dormId="+dormid+"";
                    SqlCommand mycom1 = new SqlCommand(sqlquery1, conn);
                    mycom1.ExecuteNonQuery();
                    //MessageBox.Show("人数小于4的更新成功");
                }
                else if(value1 >= 4 && value2 == "可入住")
                {
                    dormid = (int)datatable.Rows[i].ItemArray[0];
                    //update dorm set flag1='可入住' where dormId=5
                    string sqlquery1 = @"update dorm set flag1='不可入住' where dormId=" + dormid + "";
                    SqlCommand mycom1 = new SqlCommand(sqlquery1, conn);
                    mycom1.ExecuteNonQuery();
                    //MessageBox.Show("人数大于4的更新成功");
                }
            }
            
            
            //int value = (int)datatable.Rows[0].ItemArray[1];
            //string output = value.ToString();
            //MessageBox.Show(output);
            conn.Close();
        }

        public void Updateflag2()
        {
            int credit = 0;
            int myflag = 0;
            int dormid = 0;
            //select dormId,memo,flag2 from dorm
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string sqlquery = @"select dormId,memo,flag2 from dorm";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            int rowCount = datatable.Rows.Count;
            
            for (int i = 0; i < rowCount; i++)
            {
                credit = (int)datatable.Rows[i].ItemArray[1];
                
                if (credit<18)
                {
                    myflag = 1;
                    dormid = (int)datatable.Rows[i].ItemArray[0];
                    //update dorm set flag2=1 where dormId=1
                    string sqlquery1 = @"update dorm set flag2=1 where dormId="+dormid+"";
                    SqlCommand mycom1 = new SqlCommand(sqlquery1, conn);
                    mycom1.ExecuteNonQuery();
                    //MessageBox.Show("卫生分小于18的警告成功");
                }
                else
                {
                    myflag = 0;
                    dormid = (int)datatable.Rows[i].ItemArray[0];
                    //update dorm set flag2=1 where dormId=1
                    string sqlquery1 = @"update dorm set flag2=0 where dormId=" + dormid + "";
                    SqlCommand mycom1 = new SqlCommand(sqlquery1, conn);
                    mycom1.ExecuteNonQuery();
                    //MessageBox.Show("卫生分大于18的修改为0成功");
                }
            }

        }
        private void btnCreditquery_Click(object sender, EventArgs e)
        {
            if (dormCreditQuery.sign == false)
            {
                dormCreditQuery f = new dormCreditQuery();
                //f.MdiParent = this;
                dormCreditQuery.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }
    }
}
