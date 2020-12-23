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

namespace frmWin.charge
{
    public partial class Form1 : Form
    {
        public Form1(string chargeId)
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int chargeId = Convert.ToInt32(txtchargeId.Text);
            string chargeName = txtchargeName.Text;
            int fk_stuId = Convert.ToInt32(txtfk_stuId.Text);
            int fk_teachId = Convert.ToInt32(txtfk_teachId.Text);

            string payWay = "";
            if (rdoMan.Checked) payWay = "微信";
            else payWay = "支付宝";

            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select chargeId from charge", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                chargeId = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            chargeId++;
            //insert into dormtype(typeId,typeName,personcount,price,sex,memo) values (5,'三人间(男)',3,600,'男','nothing' )
            //insert into dormtype(typeId,typeName,personcount,price,sex,memo) values ("+dormtype_id+",'"typename+"',"+personcount+","+price",'"+sex+"','"+memo+"' )";
            string myinsert = @"insert into charge(chargeId,chargeName,fk_stuId,fk_teachId,payWay) values (" + chargeId + ",'" + chargeName + "'," + fk_stuId + ",'" + fk_teachId + "','" + payWay + "' )";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            MessageBox.Show(chargeName + "收费类型已经添加成功");
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