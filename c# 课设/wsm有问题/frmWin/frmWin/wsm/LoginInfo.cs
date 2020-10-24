using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace frmWin.wsm
{
    /// <summary>
    /// 此类专门用来查询登录用户的所有信息
    /// </summary>
    class LoginInfo
    {
        ///此方法用来查询教师表中的详细信息
        /// 便于教师登录后使用
        /// <param name="name">自定义声明变量 用来保存 用户名</param>
        /// <param name="pwd">自定义声明变量 用来保存 用户密码</param>
        /// <returns>返回查询后的所有信息</returns>


        public DataTable studentLogin(string name, string pwd)
        {
            SqlConnection conn = new SqlConnection("server=localhost,1433;database=register_translate;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select stuid id,stuname name,stuusername username,stupass pass,fk_classId,fk_dormId from student where stuusername=" + name + " and stupass=" + pwd, conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            if (reader.Read())
            {
                User.id = Convert.ToString(reader["userid"]); //获取账号赋值给id。
                User.name = Convert.ToString(reader["name"]);
                User.username = Convert.ToString(reader["username"]);
                User.pwd = Convert.ToString(reader["pwd"]);
                dt.Columns.Add(User.id);
                dt.Columns.Add(User.name);
                dt.Columns.Add(User.username);
                dt.Columns.Add(User.pwd);

            }
            return dt;
        }


        public DataTable teacherLogin(String tbName, string name, string pwd)
        {
            SqlConnection conn = new SqlConnection("server=localhost,1433;database=register_translate;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select teachid id,teachname name,teachusername username,teachpass pass from " + "teacher" + " where teachusername" + name + "and teachpass=" + pwd, conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            if (reader.Read())
            {
                User.id = Convert.ToString(reader["userid"]); //获取账号赋值给id。
                User.name = Convert.ToString(reader["name"]);
                User.username = Convert.ToString(reader["username"]);
                User.pwd = Convert.ToString(reader["pwd"]);
                dt.Columns.Add(User.id);
                dt.Columns.Add(User.name);
                dt.Columns.Add(User.username);
                dt.Columns.Add(User.pwd);

            }
            return dt;
        }
    }
}
