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
    public partial class dormInsertFrm2 : Form
    {
        public dormInsertFrm2()
        {
            InitializeComponent();
            LoadDormType();
            LoadBuilding();
            
        }
        public void LoadDormType()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select typeName from dormtype ", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.cboDormType.Items.Add(reader[0].ToString());
            }
            cboDormType.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();

        }


        public void LoadBuilding()
        {
            
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select buildName from building ", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.cboBuilding.Items.Add(reader[0].ToString());
            }
            cboBuilding.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();

        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string dormnum = txtDormNum.Text;
            int dormtype = Convert.ToInt32(cboDormType.Text);
            int building = Convert.ToInt32(cboBuilding.Text);
            int room_id = 0;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select dormId from building", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                room_id = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            room_id++;
            string myinsert = "insert into dorm(dormId,dormNum,fk_typeId,fk_buildid,personCount,memo,flag) values (" + room_id + "," + dormnum + "," + dormtype + ",'" + building + "')";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            MessageBox.Show(dormnum + "寝室楼已经添加成功");
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
