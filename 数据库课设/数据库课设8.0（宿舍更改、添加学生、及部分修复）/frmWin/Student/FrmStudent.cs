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

namespace frmWin.Student
{
    public partial class FrmStudent : Form
    {
        public MyGlobal jumpinfo;
        public string stuId = "1";
        public void Initdisp()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select stuNum,stuName,sex,tel,inDate,city from student where stuId = " +stuId, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            this.stunum.Text = reader[0].ToString();
            this.name.Text = reader[1].ToString();
            this.sex.Text = reader[2].ToString();
            this.telnum.Text = reader[3].ToString();
            this.CreateTime.Text = reader[4].ToString();
            this.city.Text = reader[5].ToString();
            conn.Close();
            reader.Close();
        }
        public FrmStudent(MyGlobal jumpinfo2)
        {
            this.jumpinfo = jumpinfo2;
            if (this.jumpinfo.user == "teacher")
            {
                MessageBox.Show("请用学生身份登录");
                this.Size = new Size(500, 0);
                return;
            }
            stuId = jumpinfo.stuId;
            InitializeComponent();
            Initdisp();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ChangeStuInfo ChangeInfo = new ChangeStuInfo(jumpinfo);
            ChangeInfo.ShowDialog();
            Initdisp();
        }
    }
}
