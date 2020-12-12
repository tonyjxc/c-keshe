using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using keshe;
using frmWin.fun;

namespace frmWin.building
{
    /// <summary>
    /// 专门用来连接数据库的类
	/// 其中有增删改和分页以及统计总条数等方法
	/// 方便于之后处理数据时进行调用
    /// </summary>
    class buildingWSM
    {
        //专门用来添加数据的方法
        /// sql语句可以连接数据库进行操作数据
        public void insert(building t)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("insert into building(buildName,dormCount,dormFloor) values('{0}','{1}','{2}')", t.buildName, t.dormCount, t.dromFloor);
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Close();
            conn.Close();
        }
        public void update(building t)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("update building set buildName = '{0}',dormCount = '{1}',dormFloor = '{2}' where buildId = {3}", t.buildName, t.dormCount, t.dromFloor, t.buildId);
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Close();
            conn.Close();
        }
        public void delete(building t)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("delete from building where buildId = {0}", t.buildId);
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader;
            try
            {
                reader = sql.ExecuteReader();
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("该项正在被使用，无法删除！", "温馨提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
            }
        }
        public DataTable findAll(building t, PageHelper page)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();

            //分页有问题！！！！！！！！！
            //mysql:"select * from building where buildName like '%{0}%' order by buildId asc limit {1},{2} ", t.buildName, page.getBegin(), page.pageSize
            //sqlserver：  select top 2 * from building where buildName like '%1%' order by buildId asc
            //应该变成      "select top ‘{0}’ * from building where buildName like '%{1}%' order by buildId asc",page.pageSize,t.buildName
            string mysql = string.Format("select top '{0}' * from building where buildName like '%{1}%' order by buildId asc", page.pageSize, t.buildName);
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())//决定行数
            {
                dt.Columns.Add(reader.ToString());
            }
            reader.Close();
            conn.Close();
            return dt;
        }
        public int count(building t)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("select * from building where buildName like '%{0}%'", t.buildName);
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())//决定行数
            {
                dt.Columns.Add(reader.ToString());
            }
            reader.Close();
            conn.Close();
            return dt.Rows.Count;
        }
        /// <summary>
        /// 此方法用来查询building表中的所有数据
		/// 为之后的下拉框中的数据做准备
        /// </summary>
        /// <returns></returns>
        public DataTable queryAll()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("select * from building");
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())//决定行数
            {
                dt.Columns.Add(reader.ToString());
            }
            reader.Close();
            conn.Close();
            return dt;
        }
    }
}
