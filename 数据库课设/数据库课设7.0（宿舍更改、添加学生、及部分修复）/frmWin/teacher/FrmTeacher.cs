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

namespace frmWin.teacher
{
    public partial class FrmTeacher : Form
    {
        public string teachid;
        public MyGlobal jumpinfo;
        public FrmTeacher(MyGlobal jumpinfo2)
        {
            this.jumpinfo = jumpinfo2;
            if (this.jumpinfo.user == "student")
            {
                MessageBox.Show("请用教师身份登录");
                this.Size = new Size(500, 0);
                return;
            }
            this.teachid = jumpinfo.teachId;
            InitializeComponent();
            Initdisp();
        }

        public void Initdisp()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select teachUserName,teachName,sex,tel,hireDate,specialty from teacher where teachId = " + teachid, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.teachnum.Text = reader[0].ToString();
            this.name.Text = reader[1].ToString();
            this.sex.Text = reader[2].ToString();
            this.telnum.Text = reader[3].ToString();
            this.CreateTime.Text = reader[4].ToString();
            this.specialty.Text = reader[5].ToString();
            conn.Close();
            reader.Close();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ChangeTeachInfo ChangeInfo = new ChangeTeachInfo(jumpinfo);
            ChangeInfo.ShowDialog();
            Initdisp();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
