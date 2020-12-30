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
    public partial class dormUpdateFrm2 : Form
    {
        public static bool sign = false;
        public string ChangedormName = "";
        public string ChangebuildName = "";
        public string ChangebuildidName = "";
        public dormUpdateFrm2(string name1,string name2, string name3)
        {
            this.ChangedormName = name1;
            this.ChangebuildName = name2;
            this.ChangebuildidName = name3;
            InitializeComponent();
            dormDisp();
            //dormUpdateFrm2 update = new dormUpdateFrm2(DormName, BuildName);
            
        }
        public void dormDisp()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //两个表链接查询
            //select distinct dormNum,fk_typeId,fk_buildid,personCount,memo,flag
            //from dorm left join building
            //on fk_buildid = 1
            //where dormNum = 666 and buildName = '宿舍楼1'
            //测试：select distinct dormNum,fk_typeId,fk_buildid,personCount,memo,flag from dorm left join building on fk_buildid = 1 where dormNum = 666 and buildName = '宿舍楼1'
            string myinsert = @"select distinct dormNum,fk_typeId,fk_buildid,personCount,dorm_grade,liveflag from dorm left join building on fk_buildid ='"+ ChangebuildidName + " 'where dormNum = '" + ChangedormName + "' and buildName = '" + ChangebuildName + "'";
            SqlCommand sql = new SqlCommand(myinsert, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            txtDormNum.Text = reader[0].ToString();
            txtDormType.Text = reader[1].ToString();
            txtBuildId.Text = reader[2].ToString();
            txtPersonCount.Text = reader[3].ToString();
            txtMemo.Text = reader[4].ToString();
            txtFlag.Text= reader[5].ToString();
            reader.Close();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string dormnum = txtDormNum.Text;
            int dormtype = int.Parse(txtDormType.Text);
            int personcount = int.Parse(txtPersonCount.Text);
            int buildid = int.Parse(txtBuildId.Text);
            string dormflag = txtFlag.Text;
            string dormmemo = txtMemo.Text;
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();

            //update building set dormNum = " + dormnum + ", fk_typeId = " + dormtype + ", fk_buildid = '" + buildid + ",personCount="+personcount+",memo="+dormmemo+",flag="+dormflag+"'";  and fk_buildid ='"+ChangebuildName+ "'";
            string myinsert = @"update dorm set dormNum = '" + dormnum + "', fk_typeId = " + dormtype + ", fk_buildid = " + buildid + ",personCount=" + personcount + ",dorm_grade='" + dormmemo + "',liveflag='" +dormflag + "' where dormNum = '" + ChangedormName +  "'";
            SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
            

            mycom.ExecuteNonQuery();
            MessageBox.Show(dormnum + "寝室已经修改成功");
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dormUpdateFrm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
        }
    }
}
