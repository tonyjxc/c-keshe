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
        public static bool sign = false;
        public dormManageFrm2()
        {
            InitializeComponent();
            LoadDormName();
            LoadBuildName();
            LoadDormInfo();
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
            string sqlquery = @"select fk_buildid from dorm where dormNum ='"+ DormName + "' ";
            SqlCommand mycom = new SqlCommand(sqlquery, conn);
            SqlDataReader reader = mycom.ExecuteReader();
            reader.Read();
            string buildid = reader[0].ToString();
            
            dormUpdateFrm2 duf = new dormUpdateFrm2(DormName, BuildName, buildid);
            duf.Show();
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
    }
}
