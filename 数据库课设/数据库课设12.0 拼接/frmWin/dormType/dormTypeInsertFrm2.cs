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

namespace frmWin.dormType
{
    public partial class dormTypeInsertFrm2 : Form
    {
        public dormTypeInsertFrm2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string typename = txtTypeName.Text;
            int personcount = Convert.ToInt32(txtPersonCount.Text);
            int price = Convert.ToInt32(txtPrice.Text);
            string mymemo = txtMemo.Text;
            string sex = "";
            if (rdoMan.Checked) sex = "男";
            else sex = "女";
            int dormtype_id = 0;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select typeId from dormtype", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                dormtype_id = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            dormtype_id++;
            //insert into dormtype(typeId,typeName,personcount,price,sex,memo) values (5,'三人间(男)',3,600,'男','nothing' )
            //insert into dormtype(typeId,typeName,personcount,price,sex,memo) values ("+dormtype_id+",'"typename+"',"+personcount+","+price",'"+sex+"','"+memo+"' )";
            string myinsert = @"insert into dormtype(typeId,typeName,personcount,price,sex,memo) values (" + dormtype_id + ",'"+typename + "'," + personcount + "," + price+",'" + sex + "','" + mymemo + "' )";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            MessageBox.Show(typename + "寝室楼已经添加成功");
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
