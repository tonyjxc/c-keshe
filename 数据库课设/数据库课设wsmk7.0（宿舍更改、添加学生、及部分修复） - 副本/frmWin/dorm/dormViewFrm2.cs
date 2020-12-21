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
    public partial class dormViewFrm2 : Form
    {

        public static bool sign = false;
        public string ChangedormName = "";
        public string ChangebuildName = "";
        public string ChangebuildidName = "";
        public string ChangetypeidName = "";
        public dormViewFrm2(string name1, string name2, string name3,string name4)
        {
            this.ChangedormName = name1;
            this.ChangebuildName = name2;
            this.ChangebuildidName = name3;
            this.ChangetypeidName = name4;
            InitializeComponent();
            dormDisp();

        }
        public void dormDisp()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //在sql中的查询语句（成功多条重复选择第一个）
            //select distinct dormID,dormNum,typeName,buildName,dorm.personCount,flag,dorm.memo 
            //from(dorm left join building on fk_buildid = 2)  left join dormtype on typeId = 4
            //where dormNum = 613 and buildName='宿舍楼2'
            //"select distinct dormID,dormNum,typeName,buildName,dorm.personCount,flag,dorm.memo from(dorm left join building on fk_buildid = '" + ChangebuildidName + ")  left join dormtype on typeId = '" + ChangetypeidName + "' where dormNum  = '" + ChangedormName + "' and buildName = '" + ChangebuildName + "'";
            string myinsert = @"select distinct dormID,dormNum,typeName,buildName,dorm.personCount,flag,dorm.memo from(dorm left join building on fk_buildid = '" + ChangebuildidName + "')  left join dormtype on typeId = '" + ChangetypeidName + "' where dormNum  = '" + ChangedormName + "' and buildName = '" + ChangebuildName + "'";
            SqlCommand sql = new SqlCommand(myinsert, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            txtDormId.Text = reader[0].ToString();
            txtDormNum.Text = reader[1].ToString();
            txtType.Text = reader[2].ToString();
            txtBuilding.Text = reader[3].ToString();
            txtPerson.Text = reader[4].ToString();
            txtFlag.Text = reader[5].ToString();
            txtMemo.Text= reader[6].ToString();
            reader.Close();

        }

        private void dormViewFrm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
