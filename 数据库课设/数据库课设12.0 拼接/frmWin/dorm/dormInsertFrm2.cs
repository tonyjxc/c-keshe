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
    public partial class dormInsertFrm2 : Form
    {
        public static bool sign = false;
        public dormInsertFrm2()
        {
            InitializeComponent();
            LoadDormType();
            LoadBuilding();
            
        }
        public void LoadDormType()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select typeName from dormtype ", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.cboDormType.Items.Add(reader[0].ToString());
            }
            cboDormType.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();

        }


        public void LoadBuilding()
        {
            
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select buildName from building ", conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read())
            {
                this.cboBuilding.Items.Add(reader[0].ToString());
            }
            cboBuilding.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();

        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string dormnum = this.txtDormNum.Text;
            
            int room_id = 0;
            string dormtypename = this.cboDormType.Text;
            string myquery = @"select typeID from dormtype where typeName='" + dormtypename + "'";
            SqlCommand sql2 = new SqlCommand(myquery, conn);
            SqlDataReader reader2 = sql2.ExecuteReader();
            reader2.Read();
            int dormtypeid = Convert.ToInt32(reader2[0]);
            reader2.Close();
            string buildName = this.cboBuilding.Text;
            string myquery3 = @"select buildId from building where buildName='"+buildName+"'";
            SqlCommand sql3 = new SqlCommand(myquery3, conn);
            SqlDataReader reader3 = sql3.ExecuteReader();
            reader3.Read();
            int buildid = Convert.ToInt32(reader3[0]);
            reader3.Close();
            //select sex from building where buildName='宿舍楼1'
            string myquery1 = @"select sex from building where buildName='"+ buildName + "'";
            SqlCommand sql4 = new SqlCommand(myquery1, conn);
            SqlDataReader reader4 = sql4.ExecuteReader();
            reader4.Read();
            string buildsex = reader4[0].ToString();
            reader4.Close();
            //select sex from dormtype where typeName='四人间（女）'
            string myquery5 = @"select sex from dormtype where typeName='"+ dormtypename + "'";
            SqlCommand sql5 = new SqlCommand(myquery5, conn);
            SqlDataReader reader5 = sql5.ExecuteReader();
            reader5.Read();
            string dormtypesex = reader5[0].ToString();
            
            
            reader5.Close();
            //String.Compare(str1, str2) == 0 
            //String.Compare(buildsex, dormtypesex) == 0
            if (String.Compare(buildsex, dormtypesex) == 0)
            {
                SqlCommand sql = new SqlCommand("select dormId from dorm", conn);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    room_id = Convert.ToInt32(reader[0]);
                }
                reader.Close();
                room_id++;
                string myinsert = "insert into dorm(dormId,dormNum,fk_typeId,fk_buildid,personCount,liveflag,dorm_grade,warnflag) values (" + room_id + "," + dormnum + "," + dormtypeid + ",'" + buildid + "',0,'可入住',0,0)";
                SqlCommand mycom = new SqlCommand(myinsert, conn);               //定义OleDbCommnad对象并连接数据库 
                mycom.ExecuteNonQuery();
                MessageBox.Show(dormnum + "寝室楼已经添加成功");
                
            }
            else
            {
                MessageBox.Show(dormtypename + "的性别是" + dormtypesex + ",但是" + buildName + "的性别是" + buildsex + "请插入正确的性别楼号！！！");
                MessageBox.Show("插入不成功，请重试");
            }

            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dormInsertFrm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign = false;
        }
    }
}
