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
    public partial class dormCredit : Form
    {
        public static bool sign = false;
        public dormCredit()
        {
            InitializeComponent();
            infoDisp();
        }
        public void infoDisp()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql2 = new SqlCommand("select buildName from building ", conn);
            SqlDataReader reader2 = sql2.ExecuteReader();
            while (reader2.Read())
            {
                this.txtSinglebuild.Items.Add(reader2[0].ToString());
                this.txtBatchbuild1.Items.Add(reader2[0].ToString());
                this.txtBatchbuild2.Items.Add(reader2[0].ToString());
                this.txtBatchbuild3.Items.Add(reader2[0].ToString());
                this.txtBatchbuild4.Items.Add(reader2[0].ToString());


            }
            txtBatchbuild1.SelectedIndex = 0;
            txtBatchbuild2.SelectedIndex = 0;
            txtBatchbuild3.SelectedIndex = 0;
            txtBatchbuild4.SelectedIndex = 0;
            txtSinglebuild.SelectedIndex = 0;
            reader2.Close();

            /*string myinsert1 = @"select buildName from building";
            SqlCommand sql1 = new SqlCommand(myinsert1, conn);
            SqlDataReader reader1 = sql1.ExecuteReader();
            reader1.Read();
            txtSinglebuild.Text = reader1[0].ToString();
            txtBatchbuild1.Text = reader1[0].ToString();
            txtBatchbuild2.Text = reader1[0].ToString();
            txtBatchbuild3.Text = reader1[0].ToString();
            txtBatchbuild4.Text = reader1[0].ToString();
            reader1.Close();
            */


            SqlCommand sql = new SqlCommand("select dormNum from dorm ", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.txtBatchdorm1.Items.Add(reader[0].ToString());
                this.txtBatchdorm2.Items.Add(reader[0].ToString());
                this.txtBatchdorm3.Items.Add(reader[0].ToString());
                this.txtBatchdorm4.Items.Add(reader[0].ToString());
                this.txtSingledorm.Items.Add(reader[0].ToString());
                

            }
            txtBatchdorm1.SelectedIndex = 0;
            txtBatchdorm2.SelectedIndex = 0;
            txtBatchdorm3.SelectedIndex = 0;
            txtBatchdorm4.SelectedIndex = 0;
            txtSingledorm.SelectedIndex = 0;

            //设置id值属性和文本属性
            reader.Close();


            
            string myinsert3 = @"select dorm_grade from dorm";
            SqlCommand sql3 = new SqlCommand(myinsert3, conn);
            SqlDataReader reader3 = sql3.ExecuteReader();
            reader3.Read();
            txtSinglecredit.Text= reader3[0].ToString();
            txtBatchcredit1.Text= reader3[0].ToString();
            txtBatchcredit2.Text = reader3[0].ToString();
            txtBatchcredit3.Text = reader3[0].ToString();
            txtBatchcredit4.Text = reader3[0].ToString();
            reader3.Close();

        }

        private void btnSinglesubmit_Click(object sender, EventArgs e)
        {
            string buildName = this.txtSinglebuild.Text;
            string dormName = this.txtSingledorm.Text;
            string credit = this.txtSinglecredit.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select buildid from building where buildName='宿舍楼1'
            string myquery = @"select buildid from building where buildName='"+ buildName + "'";
            SqlCommand mycom1 = new SqlCommand(myquery, conn);
            SqlDataReader reader = mycom1.ExecuteReader();
            reader.Read();
            string buildid= reader[0].ToString();
            //update dorm set flag2=1 where dormNum=417 and fk_buildid=1
            reader.Close();
            string myupdate = @"update dorm set dorm_grade=" + credit + " where dormNum='"+dormName+"' and fk_buildid="+buildid+"";
            SqlCommand mycom = new SqlCommand(myupdate, conn);           
            mycom.ExecuteNonQuery();
            MessageBox.Show("单个寝室卫生修改成功");
            
            conn.Close();
        }

        private void btnBatchsubmit_Click(object sender, EventArgs e)
        {
            string buildName1 = this.txtBatchbuild1.Text;
            string buildName2 = this.txtBatchbuild2.Text;
            string buildName3 = this.txtBatchbuild3.Text;
            string buildName4 = this.txtBatchbuild4.Text;
            string dormName1 = this.txtBatchdorm1.Text;
            string dormName2 = this.txtBatchdorm2.Text;
            string dormName3 = this.txtBatchdorm3.Text;
            string dormName4 = this.txtBatchdorm4.Text;
            string credit1 = this.txtBatchcredit1.Text;
            string credit2 = this.txtBatchcredit2.Text;
            string credit3 = this.txtBatchcredit3.Text;
            string credit4 = this.txtBatchcredit4.Text;


            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //select buildid from building where buildName='宿舍楼1'
            string myquery1 = @"select buildid from building where buildName='" + buildName1 + "'";
            string myquery2 = @"select buildid from building where buildName='" + buildName2 + "'";
            string myquery3 = @"select buildid from building where buildName='" + buildName3 + "'";
            string myquery4 = @"select buildid from building where buildName='" + buildName4 + "'";

            //update dorm set flag2=1 where dormNum=417 and fk_buildid=1
            SqlCommand mycom1 = new SqlCommand(myquery1, conn); SqlDataReader reader1 = mycom1.ExecuteReader(); reader1.Read();
            string buildid1 = reader1[0].ToString();
            string myupdate1 = @"update dorm set dorm_grade=" + credit1 + " where dormNum='" + dormName1 + "' and fk_buildid=" + buildid1 + "";
            reader1.Close();

            SqlCommand mycom2 = new SqlCommand(myquery2, conn); SqlDataReader reader2 = mycom2.ExecuteReader(); reader2.Read();
            string buildid2 = reader2[0].ToString();
            string myupdate2 = @"update dorm set dorm_grade=" + credit2 + " where dormNum='" + dormName2 + "' and fk_buildid=" + buildid2 + "";
            reader2.Close();

            SqlCommand mycom3 = new SqlCommand(myquery3, conn); SqlDataReader reader3 = mycom3.ExecuteReader(); reader3.Read();
            string buildid3 = reader3[0].ToString();
            string myupdate3 = @"update dorm set dorm_grade=" + credit3 + " where dormNum='" + dormName3 + "' and fk_buildid=" + buildid3 + "";
            reader3.Close();

            SqlCommand mycom4 = new SqlCommand(myquery4, conn); SqlDataReader reader4 = mycom4.ExecuteReader(); reader4.Read();
            string buildid4 = reader4[0].ToString();
            string myupdate4 = @"update dorm set dorm_grade=" + credit4 + " where dormNum='" + dormName4 + "' and fk_buildid=" + buildid4 + "";
            reader4.Close();

            SqlCommand com1 = new SqlCommand(myupdate1, conn);
            SqlCommand com2 = new SqlCommand(myupdate2, conn);
            SqlCommand com3 = new SqlCommand(myupdate3, conn);
            SqlCommand com4 = new SqlCommand(myupdate4, conn);
            com1.ExecuteNonQuery();
            com2.ExecuteNonQuery();
            com3.ExecuteNonQuery();
            com4.ExecuteNonQuery();
            MessageBox.Show("批量寝室卫生修改成功");
            
            conn.Close();
        }

        private void dormCredit_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

