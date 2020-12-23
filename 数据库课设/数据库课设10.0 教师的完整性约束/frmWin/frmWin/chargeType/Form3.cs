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
            string myinsert = @"select typeid,chargeName,unitPrice,memo from chargeType where typeid='" + ChangedormtypeName + "'";
            SqlCommand sql = new SqlCommand(myinsert, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            txttypeid.Text = reader[0].ToString();
            txttypeName.Text = reader[1].ToString();
            txtunitPrice.Text = reader[2].ToString();
            txtmemo.Text = reader[3].ToString();

            reader.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int typeid = int.Parse(txttypeid.Text);
            string typeName = txttypeName.Text;
            decimal unitPrice = decimal.Parse(txtunitPrice.Text);
            string memo = txtmemo.Text;


            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //数据库：update dormtype set typeName='三人间test',personcount=3,price=600,sex='男',memo='nothing' where typeName='三人间(男)'
            //update dormtype set typeName = '"+typename+"', personcount = "+personcount+", price = "+dormprice+", sex = '"+mysex"', memo = '"+dormtypememo+"' where typeName = '"+typename+"'";
            string myinsert = @"update chargeType set typeid = " + typeid + ",chargeName = '" + typeName + "', unitPrice = " + unitPrice + ", memo = '" + memo + "' where typeid = '" + ChangedormtypeName + "'";
            SqlCommand mycom = new SqlCommand(myinsert, conn);  //定义OleDbCommnad对象并连接数据库 
            mycom.ExecuteNonQuery();
            MessageBox.Show(typeName + "费用类型已经修改成功");
            conn.Close();
        }
        private void dormTypeUpdateFrm2_Load(object sender, EventArgs e)
        {

        }
    }
}