using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using keshe;
using frmWin.fun;

namespace frmWin.dorm
{
    /// <summary>
    /// 专门用来连接数据库的类
	/// 其中有增删改和分页以及统计总条数的5个方法
	/// 方便于之后处理数据时进行调用
    /// </summary>
    class dormwsm
    {
        /// <summary>
        /// 专门用来添加数据的方法
        /// sql语句可以连接数据库进行操作数据
        /// </summary>
        /// dorm是实体类
        /// 用来保存用户提交的参数
        /// 方便此方法多次使用且数据不会被覆盖
        /// <param name="d"></param>
        public void insert(dorm d)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("insert into dorm(dormNum,fk_typeId,fk_buildId,personCount,flag) values('{0}',{1},{2},0,{3})",
                                                        d.dormNum, d.fk_typeId, d.fk_buildId, d.flag);
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Close();
            conn.Close();
        }
        /// <summary>
        /// 专门用来修改数据的方法
        /// sql语句可以连接数据库进行操作数据
        /// </summary>
        /// <param name="d"></param>
        public void update(dorm d)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("update dorm set dormNum = {0},fk_typeId = {1},fk_buildid = {2},personCount = {3},flag = {4},memo = '{5}' where dormId = {6}",
                                                                d.dormNum, d.fk_typeId, d.fk_buildId, d.personCount, d.flag, d.memo, d.dormId);
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Close();
            conn.Close();
        }
        /// <summary>
        /// 按类型名称进行模糊查询
        /// 可以查询到用户所需要的数据
        /// </summary>
        /// <param name="d"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public DataTable findAll(dorm d, PageHelper page)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("select dormId,dormNum,personCount from dorm where dormNum like '%{0}%' and flag = {1} order by dormId asc limit {2},{3}",
                                                d.dormNum, d.flag, page.getBegin(), page.pageSize);
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
        public DataTable FindDormById(string id)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format(@"select s.stuNum 学生编号,s.stuName 学生姓名,s.sex 性别,s.fk_classId 班级,s.fk_dormId 宿舍号 from student s");
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())//决定行数
            {
                dt.Columns.Add(reader.ToString());//???
            }
            reader.Close();
            conn.Close();
            return dt;
        }
        /// <summary>
        /// 此方法用来查询总人数
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public DataTable findPerson(dorm d)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("select personCount from dorm where dormId  = {0}",
                                                d.dormId);
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())//决定行数
            {
                dt.Columns.Add(reader[0].ToString());//personCount
            }
            reader.Close();
            conn.Close();
            return dt;
        }
        /// <summary>
        /// 按类型名称进行模糊查询
        /// 可以查询到用户所需要的数据
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int count(dorm d)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("select * from dorm where dormNum like '%{0}%' and flag = {1}", d.dormNum, d.flag);
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
        /// 修改,宿舍是否能入住
        /// </summary>
        /// <param name="d"></param>
        public void updateFlag(dorm d)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("update dorm set flag=2 where dormId={0}", d.dormId);

            try
            {
                SqlCommand sql = new SqlCommand(mysql, conn);
                SqlDataReader reader = sql.ExecuteReader();
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("该项正在被使用，无法修改！", "温馨提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
            }
        }
        /// <summary>
        /// 此方法用来查询dorm表中的所有数据
        /// 为之后的下拉框中的数据做准备
        /// </summary>
        /// <returns></returns>
        public DataTable queryAll()
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("select * from dorm");
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
        /// <summary>
        /// 用来查询building表中的所有数据
        /// </summary>
        /// <returns></returns>

        public DataTable queryBuildAll()
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

        //根据班级编号查询教师信息
        public DataTable findById(dorm d)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("select * from dorm d inner join dormtype dt on d.fk_typeId = dt.typeId where d.dormId={0} ", d.dormId);
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

        //用来查询宿舍信息
        public DataTable findByBuilding(dorm d)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("select * from dorm d inner join building b on d.fk_buildid = b.buildId where d.dormId={0} ", d.dormId);
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
        //处理宿舍类型的外键
        public DataTable findByType(dorm d)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("select typeName from dorm inner join dormtype on dorm.fk_typeId = dormtype.typeId where dormId = {0}", d.dormId);
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())//决定行数
            {
                dt.Columns.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            return dt;
        }
        //查询宿舍所在楼层
        public DataTable findByBuild(dorm d)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("select buildName from dorm inner join building on dorm.fk_buildid = building.buildId where dormId = {0}", d.dormId);
            SqlCommand sql = new SqlCommand(mysql, conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            while (reader.Read())//决定行数
            {
                dt.Columns.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            return dt;
        }
        //查询宿舍类型
        public DataTable findByDormType()
        {

            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            string mysql = string.Format("select * from dormtype");
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
        //查询宿舍楼
        public DataTable findByBuilding()
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