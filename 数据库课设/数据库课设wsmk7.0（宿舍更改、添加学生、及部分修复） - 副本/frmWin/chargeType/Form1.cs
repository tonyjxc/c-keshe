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

namespace frmWin.chargeType
{
    public partial class Form1 : Form
    {
        public Form1(string typeid)
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int typeid = Convert.ToInt32(txttypeid.Text);
            string typeName = txttypeName.Text;
            decimal unitPrice = Convert.ToDecimal(txtunitPrice.Text);
            string memo= txtmemo.Text;

            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select typeid from chargeType", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                typeid = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            typeid++;
            //insert into dormtype(typeId,typeName,personcount,price,sex,memo) values (5,'三人间(男)',3,600,'男','nothing' )
            //insert into dormtype(typeId,typeName,personcount,price,sex,memo) values ("+dormtype_id+",'"typename+"',"+personcount+","+price",'"+sex+"','"+memo+"' )";
            string myinsert = @"insert into chargeType(typeid,typeName,unitPrice,memo) values (" + typeid + ",'" + typeName + "'," + unitPrice + ",'" + memo + "' )";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            MessageBox.Show(typeName + "费用类型已经添加成功");
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dormTypeInsertFrm2_Load(object sender, EventArgs e)
        {

        }
    }
}
