using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using keshe;
using System.Windows.Forms;

namespace frmWin.fun
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
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select * from student where stuUserName = '" + name + "' and stuPass='" + pwd + "'", conn);
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


        public DataTable teacherLogin( string name, string pwd)
        {
            SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand sql = new SqlCommand("select * from teacher where teachUserName = '"+name+"' and teachPass='"+pwd+"'", conn);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            if (reader.Read())
            {
                User.id = Convert.ToString(reader["teachId"]); //获取账号赋值给id。
                User.name = Convert.ToString(reader["teachName"]);
                User.username = Convert.ToString(reader["teachUserName"]);
                User.pwd = Convert.ToString(reader["teachPass"]);
                dt.Columns.Add(User.id);
                dt.Columns.Add(User.name);
                dt.Columns.Add(User.username);
                dt.Columns.Add(User.pwd);
            }
            return dt;
        }
    }
}
