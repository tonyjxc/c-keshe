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
            string sqlquery = @"select fk_buildid,dormNum,dorm.memo,name,flag2 from dorm,student,classinfo where fk_dormId = dormId and classId = fk_classId";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDormCredit.DataSource = datatable;
            conn.Close();
        }

        private void dormCreditQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
        }

        private void btncredit_Click(object sender, EventArgs e)
        {
            dgvDormCredit.DataSource = null;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select fk_buildid,dormNum,memo,flag2 from dorm
            string sqlquery = @"select fk_buildid,dormNum,dorm.memo,name,flag2 from dorm,student,classinfo where fk_dormId = dormId and classId = fk_classId order by memo";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDormCredit.DataSource = datatable;
            conn.Close();
        }

        private void btnclass_Click(object sender, EventArgs e)
        {
            dgvDormCredit.DataSource = null;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select distinct fk_buildid,dormNum,dorm.memo,name,flag2 
            //from dorm, student, classinfo
            //where fk_dormId = dormId and classId = fk_classId
            //group by name,fk_buildid,dormNum,dorm.memo,name,flag2
            string sqlquery = @"select distinct fk_buildid,dormNum,dorm.memo,name,flag2 from dorm, student, classinfo where fk_dormId = dormId and classId = fk_classId group by name,fk_buildid,dormNum,dorm.memo,name,flag2";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDormCredit.DataSource = datatable;
            conn.Close();
        }
    }
}
