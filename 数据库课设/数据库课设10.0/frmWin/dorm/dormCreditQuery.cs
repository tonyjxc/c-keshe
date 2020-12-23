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
//发送邮件
using System.Net;
using System.Net.Mail;

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

        private void btnmess_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //dormNum from dorm where dorm_grade<18
            string sqlquery = @"select dormNum from dorm where dorm_grade<18";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            int n = datatable.Rows.Count;
            string[] dormNumArray = new string[n];

            //MessageBox.Show("有" + n + "个人不及格");
            for(int i = 0; i < n; i++)
            {
                dormNumArray[i] = datatable.Rows[i][0].ToString();
            }
            /*
            for (int j = 0; j < n; j++)
            {
                MessageBox.Show(dormNumArray[j]);
            }*/
            conn.Close();
            string text = "";
            for (int i = 0; i < n; i++)
            {
                text += "\n"+dormNumArray[i];
            }
            MessageBox.Show(text);
            MessageBox.Show("发送成功");
            

            using (MailMessage mailMessige = new MailMessage())
            using (SmtpClient smtpClient = new SmtpClient(/*smtp服务器*/"smtp.qq.com"))
            {
                mailMessige.To.Add(/*收件人地址*/"1281032638@qq.com");
                mailMessige.Body =/*内容*/"寝室卫生警告:" + text;
                mailMessige.From = new MailAddress(/*发送的地址*/"1607617252@qq.com");
                
                mailMessige.Subject = /*邮件标题*/"寝室卫生警告";
                smtpClient.Credentials = new NetworkCredential("1607617252@qq.com", "fpujkqwrijzihicj");
                smtpClient.Send(mailMessige);
            }
            
            
        }
    }
}
