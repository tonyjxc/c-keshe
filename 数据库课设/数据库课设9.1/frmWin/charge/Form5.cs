using System;
using System.Collections.Generic;
using keshe;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmWin.chargeType;
using frmWin.dormType;
namespace frmWin.charge
{
    public partial class Form5 : Form
    {
        public static bool sign = false;
        public string teachid;
        public MyGlobal jumpinfo;
        public Form5(MyGlobal jumpinfo2)
        {
            this.jumpinfo = jumpinfo2;
            if (this.jumpinfo.user == "student")
            {
                MessageBox.Show("请用教师身份登录");
                this.Size = new Size(500, 0);
                return;
            }
            this.teachid = jumpinfo.teachId;
            InitializeComponent();
            LoadTypeName();
            LoadTypeInfo();
        }

        public void LoadTypeName()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select fk_teachId from charge ", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.cboDormTypeName.Items.Add(reader[0].ToString());
            }
            cboDormTypeName.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }
        public void LoadTypeInfo()
        {
            dgvDormType.DataSource = null;
            string dormtypename = cboDormTypeName.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //定义查询的sql语句  select typeName,personCount,price,sex,memo from dormtype where typeName='四人间（男）'
            //select typeName,personCount,price,sex,memo from dormtype where typeName='"+dormtypename+"'";
            string sqlquery = @"select chargeId,chargeName,payWay,fk_chargeId,fk_teachId from charge where fk_teachId='" + dormtypename + "'";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDormType.DataSource = datatable;
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadTypeInfo();
        }

        private void dormTypeManageFrm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            string dormtypename = cboDormTypeName.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select fk_buildid from dorm where dormNum =666 
            string sqlquery = @"select chargeId from charge where chargeId ='" + dormtypename + "'";
            SqlCommand mycom = new SqlCommand(sqlquery, conn);
            SqlDataReader reader = mycom.ExecuteReader();
            reader.Read();
            string buildid = reader[0].ToString();

            Form3 dtuf = new Form3(dormtypename);
            dtuf.Show();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dormtypename = cboDormTypeName.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select fk_buildid from dorm where dormNum =666 
            string sqlquery = @"select chargeId from charge where chargeId ='" + dormtypename + "'";
            SqlCommand mycom = new SqlCommand(sqlquery, conn);
            SqlDataReader reader = mycom.ExecuteReader();
            reader.Read();
            string buildid = reader[0].ToString();

            Form1 dtuf = new Form1(dormtypename);
            dtuf.Show();
        }

        private void cboDormTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (chargeType.Form4.sign == false)
            {
                chargeType.Form4 f = new chargeType.Form4();
                //f.MdiParent = this;
                chargeType.Form4.sign = true;
                f.Show();

            }
            else
            {
                MessageBox.Show("该窗体已经存在~");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (charge.Form7.sign == false)
            {
                charge.Form7 f = new charge.Form7();
                //f.MdiParent = this;
                charge.Form7.sign = true;
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