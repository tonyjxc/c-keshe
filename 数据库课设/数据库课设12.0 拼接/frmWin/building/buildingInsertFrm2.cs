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
using System.IO;
using System.IO.Ports;

namespace frmWin.building
{
    public partial class buildingInsertFrm2 : Form
    {
        public static bool sign = false;
        public buildingInsertFrm2()
        {
            InitializeComponent();
            buildDisp();
        }
        public void buildDisp()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select count(*) from building", conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            string builname= reader[0].ToString();
            //数字提取
            int num = 0;
            string result = System.Text.RegularExpressions.Regex.Replace(builname, @"[^0-9]+", "");
            num=int.Parse(result);
            num += 1;
            txtbuildName.Text = "宿舍楼" + num;
            reader.Close();
            this.cmbsex.Items.Add('男');
            this.cmbsex.Items.Add('女');
            cmbsex.SelectedIndex = 0;         //设置索引为0
            

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string dorm_name = txtbuildName.Text;
            int sum_room = Convert.ToInt32(txtMemo.Text);
            int sum_floor = Convert.ToInt32(txtdormFloor.Text);
            int room_id = 0;

            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select buildId from building", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                room_id = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            room_id++;
            string buildsex = this.cmbsex.Text;
            string myinsert = "insert into building(buildId,dormCount,dormFloor,buildName,sex) values (" + room_id + "," + sum_room + "," + sum_floor + ",'" + dorm_name+ "','"+buildsex+"')";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            MessageBox.Show(dorm_name + "寝室楼已经添加成功");
            conn.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buildingInsertFrm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
        }
    }
}
