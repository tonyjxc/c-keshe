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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string ChangedormtypeName = "";
        public Form3(string name1)
        {
            InitializeComponent();
            this.ChangedormtypeName = name1;
            dormtypeDisp();
        }
        public void dormtypeDisp()
        {
            string mysex = "";
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //数据库语句：select typeName,personcount,price,sex,memo from dormtype where typeName='四人间（男）'
            //select typeName,personcount,price,sex,memo from dormtype where typeName='"+ChangedormtypeName+"'";
            string myinsert = @"select chargeId,chargeName,fk_stuId,fk_teachId,payWay from charge where chargeId='" + ChangedormtypeName + "'";
            SqlCommand sql = new SqlCommand(myinsert, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            txtchargeId.Text = reader[0].ToString();
            txtchargeName.Text = reader[1].ToString();
            txtfk_stuId.Text = reader[2].ToString();
            txtfk_teachId.Text = reader[3].ToString();

            if (mysex == "微信") rdoMan.Checked = true;
            else rdoWoman.Checked = true;

            reader.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int chargeId = int.Parse(txtchargeId.Text);
            string chargeName = txtchargeName.Text;
            string fk_stuId = txtfk_stuId.Text;
            string fk_teachId = txtfk_teachId.Text;
            string payWay = "";
            if (rdoMan.Checked) payWay = "校园卡";
            else payWay = "支付宝";

            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //数据库：update dormtype set typeName='三人间test',personcount=3,price=600,sex='男',memo='nothing' where typeName='三人间(男)'
            //update dormtype set typeName = '"+typename+"', personcount = "+personcount+", price = "+dormprice+", sex = '"+mysex"', memo = '"+dormtypememo+"' where typeName = '"+typename+"'";
            string myinsert = @"update charge set  chargeId = " + chargeId + ",chargeName = '" + chargeName + "',fk_stuId = '" + fk_stuId + "',fk_teachId = '" + fk_teachId + "', payWay = '" + payWay + "' where chargeId = '" + ChangedormtypeName + "'";
            SqlCommand mycom = new SqlCommand(myinsert, conn);  //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            MessageBox.Show(chargeName + "费用类型已经修改成功");
            conn.Close();
        }
        private void dormTypeUpdateFrm2_Load(object sender, EventArgs e)
        {

        }
    }
}
