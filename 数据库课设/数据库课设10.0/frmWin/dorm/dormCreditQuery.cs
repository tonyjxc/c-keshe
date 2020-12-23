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

namespace frmWin.dorm
{
    public partial class dormCreditQuery : Form
    {
        public static bool sign = false;
        public dormCreditQuery()
        {
            InitializeComponent();
            LoadDormCreditInfo();
        }
        public void LoadDormCreditInfo()
        {
            dgvDormCredit.DataSource = null;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select fk_buildid,dormNum,memo,flag2 from dorm
            string sqlquery = @"select fk_buildid,dormNum,dorm_grade,name,warnflag from dorm,student,classinfo where fk_dormId = dormId and classId = fk_classId";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDormCredit.DataSource = datatable;

            SqlCommand sql = new SqlCommand("select name from classinfo ", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.cmbClass.Items.Add(reader[0].ToString());
            }
            cmbClass.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            
            conn.Close();
        }

        private void dormCreditQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
        }

        private void btncredit_Click(object sender, EventArgs e)
        {
            //dgvDormCredit.DataSource = null;
            
            DataTable dt1 = (DataTable)dgvDormCredit.DataSource;
            dt1.Rows.Clear();
            dgvDormCredit.DataSource = dt1;

            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select fk_buildid,dormNum,memo,flag2 from dorm
            string sqlquery = @"select fk_buildid,dormNum,dorm_grade,name,warnflag from dorm,student,classinfo where fk_dormId = dormId and classId = fk_classId order by dorm_grade";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDormCredit.DataSource = datatable;
            conn.Close();
        }

        private void btnclass_Click(object sender, EventArgs e)
        {
            //dgvDormCredit.DataSource = null;
            DataTable dt1 = (DataTable)dgvDormCredit.DataSource;
            dt1.Rows.Clear();
            dgvDormCredit.DataSource = dt1;

            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select distinct fk_buildid,dormNum,dorm.memo,name,flag2 
            //from dorm, student, classinfo
            //where fk_dormId = dormId and classId = fk_classId
            //group by name,fk_buildid,dormNum,dorm.memo,name,flag2
            string sqlquery = @"select distinct fk_buildid,dormNum,dorm_grade,name,warnflag from dorm, student, classinfo where fk_dormId = dormId and classId = fk_classId group by name,fk_buildid,dormNum,dorm_grade,name,warnflag";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDormCredit.DataSource = datatable;
            conn.Close();
        }

        private void btnavgclss_Click(object sender, EventArgs e)
        {
            string classname = cmbClass.Text;
            //select name,avg(dorm.memo) from dorm, student, classinfo where fk_dormId = dormId and classId = fk_classId and classId=1 group by name
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string sqlquery = @"select name,avg(dorm_grade) from dorm, student, classinfo where fk_dormId = dormId and classId = fk_classId and name='"+classname+"' group by name";
            SqlCommand sql = new SqlCommand(sqlquery, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            txtclass.Text = reader[1].ToString();
            reader.Close();

        }

        private void btnavgall_Click(object sender, EventArgs e)
        {
            //select avg(dorm.memo) from dorm
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string sqlquery = @"select avg(dorm_grade) from dorm";
            SqlCommand sql = new SqlCommand(sqlquery, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            txtall.Text = reader[0].ToString();
            reader.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
