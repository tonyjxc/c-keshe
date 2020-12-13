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
    public partial class dormTypeUpdateFrm2 : Form
    {
        public string ChangedormtypeName = "";
        public dormTypeUpdateFrm2(string name1)
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
            string myinsert = @"select typeName,personcount,price,sex,memo from dormtype where typeName='" + ChangedormtypeName + "'";
            SqlCommand sql = new SqlCommand(myinsert, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            txtTypeName.Text = reader[0].ToString();
            txtPersonCount.Text = reader[1].ToString();
            txtPrice.Text = reader[2].ToString();
            mysex = reader[3].ToString();
            if (mysex == "男") rdoMan.Checked = true;
            else rdoWoman.Checked = true;
            txtMemo.Text = reader[4].ToString();
            reader.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string typename = txtTypeName.Text;
            int personcount = int.Parse(txtPersonCount.Text);
            int dormprice = int.Parse(txtPrice.Text);
            string mysex = "";
            if (rdoMan.Checked) mysex = "男";
            else  mysex = "女";
         
            string dormtypememo = txtMemo.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();

            //数据库：update dormtype set typeName='三人间test',personcount=3,price=600,sex='男',memo='nothing' where typeName='三人间(男)'
            //update dormtype set typeName = '"+typename+"', personcount = "+personcount+", price = "+dormprice+", sex = '"+mysex"', memo = '"+dormtypememo+"' where typeName = '"+typename+"'";
            string myinsert = @"update dormtype set typeName = '" + typename + "', personcount = " + personcount + ", price = " + dormprice + ", sex = '" + mysex+"',memo = '" + dormtypememo + "' where typeName = '" + ChangedormtypeName + "'";
            SqlCommand mycom = new SqlCommand(myinsert, conn);  //定义OleDbCommnad对象并连接数据库 

            mycom.ExecuteNonQuery();
            MessageBox.Show(typename + "寝室类型已经修改成功");
            conn.Close();
        }
    }
}
