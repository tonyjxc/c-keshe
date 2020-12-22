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

namespace frmWin.building
{
    public partial class buildingManagerFrm2 : Form
    {
        public MyGlobal jumpinfo;
        public static bool sign = false;
        public string buildingname = "";
        public buildingManagerFrm2(MyGlobal jumpinfo2)
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
            LoadDormInfoFirst();
        }

        public void LoadDormName() 
        {
            // this.txtDromName.Items.Clear();
            // 填充宿舍
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select buildName from building ", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.txtDromName.Items.Add(reader[0].ToString());
            }
            txtDromName.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();

        }

        public void LoadDormInfoFirst() 
        {
            dgvbuilding.DataSource = null;
            this.buildingname = txtDromName.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //定义查询的sql语句
            //@"select * from building where buildName = '" +this.buildingname+"'";
            string sqlquery = @"select * from building ";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvbuilding.DataSource = datatable;
            conn.Close();
        }
        public void LoadDormInfo()
        {
            DataTable dt1 = (DataTable)dgvbuilding.DataSource;
            dt1.Rows.Clear();
            dgvbuilding.DataSource = dt1;

            dgvbuilding.DataSource = null;
            this.buildingname = txtDromName.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //定义查询的sql语句
            //@"select * from building where buildName = '" +this.buildingname+"'";
            string sqlquery = @"select * from building where buildName = '" + this.buildingname + "'";
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvbuilding.DataSource = datatable;
            conn.Close();
        }

        private void dgvbuilding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadDormInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            buildingUpdateFrm2 update = new buildingUpdateFrm2(this.buildingname);
            //MessageBox.Show(this.buildingname);
            update.Show();
        }

        private void buildingManagerFrm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            if (buildingInsertFrm2.sign == false)
            {
                buildingInsertFrm2 f = new buildingInsertFrm2();
                //f.MdiParent = this;
                buildingInsertFrm2.sign = true;
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
