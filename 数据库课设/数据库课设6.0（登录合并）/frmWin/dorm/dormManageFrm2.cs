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
            string sqlquery = @"select distinct buildName,dormNum,personCount,flag from dorm,building where buildId=fk_buildid";
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
    }
}
