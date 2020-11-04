using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using keshe;
using System.Runtime.CompilerServices;
using frmWin.fun;

namespace frmWin
{
    public partial class FrmDormAdd : Form
    {
        public FrmDormAdd()
        {
            InitializeComponent();
        }
        //加载宿舍楼
        public void LoadBuild()
        {
            // 填充宿舍离谱
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //想要达到宿舍类型名称和性别拼接起来，这样显示出来比较符合常理。
            //比如  四人间-男  二人间-女，但是中间那个-我不知道怎么用给定格式输出
            //SqlCommand sql = new SqlCommand("select buildID,dormCount,dormFloor from building", conn);
            SqlCommand sql = new SqlCommand("select buildId from building", conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())
            {
                this.cmbBuild.Items.Add(reader[0].ToString());
            }
            cmbBuild.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();

            //填充表格
            /*
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            String str = "select buildID,dormCount,dormFloor from building";
            SqlDataAdapter data = new SqlDataAdapter(str, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDorm.DataSource = datatable;
            conn.Close();
            
             */
             
             /*
            //想要加载宿舍楼的信息，那么查询
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select buildID,dormCount,dormFloor from building",conn);
            //只能一行一行的读取
            SqlDataReader reader = sql.ExecuteReader();

            ///定义DataTable  
            DataTable dt = new DataTable();
            try
            {
                ///动态添加表的数据列  
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DataColumn myDataColumn = new DataColumn();
                    myDataColumn.DataType = reader.GetFieldType(i);
                    myDataColumn.ColumnName = reader.GetName(i);
                    dt.Columns.Add(myDataColumn);
                }
                ///添加表的数据  
                while (reader.Read())
                {
                    DataRow myDataRow = dt.NewRow();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        myDataRow[i] = dt.Columns[i].ToString();
                    }
                    dt.Rows.Add(myDataRow);
                    myDataRow = null;
                }
                ///关闭数据读取器  
                reader.Close();
                return;
            }
            catch (Exception ex) 
            { MessageBox.Show("出错了" + ex.Message); }

            //我想看到的是 buildID buildName
            //              28      一号楼
            //              29      二号楼   这种效果（没有数据库）
            //              ...     ...
            //buildID是给程序使用的，buildName是给人看的

            //将DataTable的数据绑定到下拉框上
            //1.设置下拉框绑定的ID值属性
            this.cmbBuild.ValueMember = "buildID";
            //2.设置下拉框绑定的文本属性
            this.cmbBuild.DisplayMember = "buildName";
            //绑定DataTable到下拉框上
            this.cmbBuild.DataSource = dt;*/
        }

        //加载宿舍类型下拉框
        public void LoadDormType()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //想要达到宿舍类型名称和性别拼接起来，这样显示出来比较符合常理。
            //比如  四人间-男  二人间-女，但是中间那个-我不知道怎么用给定格式输出
            //SqlCommand sql = new SqlCommand("select buildID,dormCount,dormFloor from building", conn);
            SqlCommand sql = new SqlCommand("select typeID,typeName AS typeName from DormType", conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())
            {
                this.cmbDormType.Items.Add( reader[0].ToString() +"\t("+ reader[1].ToString()+"");
            }
            cmbDormType.SelectedIndex = 0;
            //设置id值属性和文本属性
            reader.Close();
            conn.Close();
        }

        //窗体加载事件，将宿舍楼显示在下拉框中
        private void FrmDormAdd_Load(object sender, EventArgs e)
        {
            try 
            {
                //加载宿舍楼
                LoadBuild();
                //加载宿舍类型
                LoadDormType();
                //显示宿舍
                QueryDorm();
            } 
            catch(Exception ex)
            {
                MessageBox.Show("出错了"+ex.Message);
            } 
         }

        //添加单个宿舍要求文本框必须是在一定范围内，就是宿舍号是在一个范围内，不能随便添加
        //所以写一个校验的
        public void SingleAddDorm()
        {
            //判断宿舍编号是否有效
            string dormnum = this.txtDormNo.Text;
            if (!Validation.ValidateInt(ref dormnum, 101,999))
            {
                MessageBox.Show("宿舍编号必须为整数，并且在101-999之间");
                return;
            }
            //定义添加单个宿舍的语句
            string sqltry = @"insert into dorm(dormNum,fk_typeID,fk_duildID,personCount,flag)
                           values
                           ('{0}', '{1}', '{2}', 0, 1)";
            //cmbDormType.SelectedValue:获取宿舍类型下拉框选项中的编号
            //this.cmbBuild.SelectedValue：获取宿舍楼下拉框选项中的编号
            sqltry = string.Format(sqltry,this.txtDormNo.Text,this.cmbDormType.SelectedValue,
                                    this.cmbBuild.SelectedValue);
            //执行sql语句
            SqlCommand sql = new SqlCommand(sqltry);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();

            try
            {
                ///动态添加表的数据列  
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DataColumn myDataColumn = new DataColumn();
                    myDataColumn.DataType = reader.GetFieldType(i);
                    myDataColumn.ColumnName = reader.GetName(i);
                    dt.Columns.Add(myDataColumn);
                }
                ///添加表的数据  
                while (reader.Read())
                {
                    DataRow myDataRow = dt.NewRow();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        myDataRow[i] = dt.Columns[i].ToString();
                    }
                    dt.Rows.Add(myDataRow);
                    myDataRow = null;
                }
                ///关闭数据读取器  
                reader.Close();
                return;
            }
            catch (Exception ex)
            { MessageBox.Show("出错了" + ex.Message); }






            int count = dt.Columns.Count;
            if(count==1)
            {
                MessageBox.Show("插入成功");
                this.txtDormNo.Text = "";
            }
            else 
            {
                MessageBox.Show("插入失败");
            }

            //执行完了之后插了几条会有count结果



            //判断宿舍编号是否存在
            //还需要做插入时的存在性校验，就是已经存在的不能重复，写在validation中
            if (!Validation.checkDormNO(ref dormnum))
            {
                MessageBox.Show("宿舍已经存在，请勿重复添加！");
                return;
            }
        }

        //宿舍查询
        public void QueryDorm()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            //定义查询的sql语句
            string sqlquery = @"select
                                  b.buildId  宿舍楼,
                                  dt.typeName  宿舍类型,
                                  dt.sex 性别,
                                  dt.personCount  额定人数,
                                  dt.price  单价,
                                  d.dormNum  宿舍编号
                                  from dorm d
                                  join dormtype dt
                                  on d.fk_typeID=dt.typeID
                                  join building b
                                  on d.fk_buildID=b.buildID
                                  where d.fk_typeID='{0}' and d.fk_buildid='{1}'";
            string dormtype = this.cmbDormType.Text;
            string temp="";
            for (int i=0;i<dormtype.Length;i++)
            {
                if (dormtype[i] != '\t')
                {
                    temp += dormtype[i];
                }
                else
                    break;
            }
            sqlquery = string.Format(sqlquery, temp, this.cmbBuild.Text);
            /*
            //把0和1的参数传进去，用一下两个作为传进去的参数
            //用宿舍楼和宿舍类型做条件，进行查询
            SqlCommand sql = new SqlCommand(sqlquery,conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            */
            SqlDataAdapter data = new SqlDataAdapter(sqlquery, conn);
            DataSet dt = new DataSet();
            data.Fill(dt, "table1");
            DataTable datatable = dt.Tables["table1"];
            dgvDorm.DataSource = datatable;
            conn.Close();



            /*
            try
            {
                ///动态添加表的数据列  
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    DataColumn myDataColumn = new DataColumn();
                    myDataColumn.DataType = reader.GetFieldType(i);
                    myDataColumn.ColumnName = reader.GetName(i);
                    dt.Columns.Add(myDataColumn);
                }
                ///添加表的数据  
                while (reader.Read())
                {
                    DataRow myDataRow = dt.NewRow();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        myDataRow[i] = dt.Columns[i].ToString();
                    }
                    dt.Rows.Add(myDataRow);
                    myDataRow = null;
                }
                ///关闭数据读取器  
                reader.Close();
                return;
            }
            catch (Exception ex)
            { MessageBox.Show("出错了" + ex.Message); }
            //将数据绑定到datagridview上
            this.dgvDorm.DataSource = dt;
            reader.Close();
            conn.Close();*/
        }
        //添加单个宿舍
        private void btnSingleAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SingleAddDorm();
                //在添加完之后也显示宿舍
                QueryDorm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错了" + ex.Message);
            }
            
        }

        //批量添加宿舍
        public void BatchAddDorm()
        {
            //这个checkif作为一个大函数，只有不重复才能批量添加
            //这里的ref有问题，和上面重复了
            //if (!Validation.checkDormNO(ref dormnum))
            //{
             //   MessageBox.Show("宿舍已经存在，请勿重复添加！");
             //   return;
            //}
            //校验宿舍的开始编号
            string dormnum = this.txtStartNo.Text;
            if(!Validation.ValidateInt(ref dormnum, 101, 999))
            {
                MessageBox.Show("宿舍开始编号必须为整数，并且在101-999之间");
                return;
            }
            //校验宿舍的结束编号
            //valida中dormnum只能使用一次，该怎么不用ref传参
            //string dormnum = this.txtEndNo.Text;
            if (!Validation.ValidateInt(ref dormnum, 101, 999))
            {
                MessageBox.Show("宿舍结束编号必须为整数，并且在101-999之间");
                return;
            }
            //校验开始和结束的宿舍编号不能超过15个宿舍
            if (int.Parse(this.txtEndNo.Text) - int.Parse(this.txtStartNo.Text)>15)
            {
                MessageBox.Show("批量添加宿舍一次不能超过15间宿舍");
                return;
            }

            string dorms = "";
            //正式开始添加宿舍
            int start = int.Parse(this.txtStartNo.Text);
            int end = int.Parse(this.txtEndNo.Text);
            for (int i=start;i<=end;i++)
            {
                //把单个添加宿舍的代码内容拿过来就行
                //定义添加单个宿舍的语句
                string sqltry = @"insert into dorm(dormNum,fk_typeID,fk_duildID,personCount,flag)
                           values
                           ('{0}', '{1}', '{2}', 0, 1)";
                //cmbDormType.SelectedValue:获取宿舍类型下拉框选项中的编号
                //this.cmbBuild.SelectedValue：获取宿舍楼下拉框选项中的编号
                sqltry = string.Format(sqltry, i, this.cmbDormType.SelectedValue,
                                        this.cmbBuild.SelectedValue);
                //执行sql语句
                SqlCommand sql = new SqlCommand(sqltry);
                SqlDataReader reader = sql.ExecuteReader();
                DataTable dt = new DataTable();
                try
                {
                    ///动态添加表的数据列  
                    for (int j = 0; j < reader.FieldCount; j++)
                    {
                        DataColumn myDataColumn = new DataColumn();
                        myDataColumn.DataType = reader.GetFieldType(j);
                        myDataColumn.ColumnName = reader.GetName(j);
                        dt.Columns.Add(myDataColumn);
                    }
                    ///添加表的数据  
                    while (reader.Read())
                    {
                        DataRow myDataRow = dt.NewRow();
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            myDataRow[j] = dt.Columns[j].ToString();
                        }
                        dt.Rows.Add(myDataRow);
                        myDataRow = null;
                    }
                    ///关闭数据读取器  
                    reader.Close();
                    return;
                }
                catch (Exception ex)
                { MessageBox.Show("出错了" + ex.Message); }

                //插入成功一个，dorms就拼接一个
                dorms +=i+" ";//i是宿舍编号

            }
            MessageBox.Show("插入成功,插入的宿舍编号有："+dorms);

            //查完之后清空文本框
            this.txtStartNo.Text = "";
            this.txtEndNo.Text = "";
        }
        private void btnBatchAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                //批量添加
                BatchAddDorm();
                //查询宿舍
                QueryDorm();
            }
            catch(Exception ex)
            {
                MessageBox.Show("出错了" + ex.Message);
            }

        }

        //宿舍楼下拉框切换事件
        private void cmbBuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbBuild.Items.Count>0&&this.cmbDormType.Items.Count>0)
            {
                //查询宿舍
                QueryDorm();
            }
            
        }

        ////宿舍类型下拉框切换事件
        private void cmbDormType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbBuild.Items.Count > 0 && this.cmbDormType.Items.Count > 0)
            {
                //查询宿舍
                QueryDorm();
            }
        }
    }
}
