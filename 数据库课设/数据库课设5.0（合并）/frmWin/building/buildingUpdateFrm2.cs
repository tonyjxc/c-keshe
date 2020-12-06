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
    public partial class buildingUpdateFrm2 : Form
    {
        public string ChangeName = "";
        public void buildDisp() 
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select * from building", conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            txtTypeName.Text = reader[3].ToString();
            txtMemo.Text = reader[1].ToString();
            txtdormFloor.Text = reader[2].ToString();
            reader.Close();

        }
        public buildingUpdateFrm2(string name)
        {
            InitializeComponent();
            buildDisp();
            this.ChangeName = name;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string dorm_name = txtTypeName.Text;
            int sum_room = Convert.ToInt32(txtMemo.Text);
            int sum_floor = Convert.ToInt32(txtdormFloor.Text);
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();


            string myinsert = @"update building set dormCount="+sum_room+",dormFloor = " +sum_floor +",buildName = '"+dorm_name +"' where buildName = '"+ ChangeName + "'";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            MessageBox.Show(dorm_name + "寝室楼已经修改成功");
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
