using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据库连接部分
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("server=tonyjxc.xyz,6220;database=register_translate;UID=sa;PWD=zyh@197068;Integrated Security=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TRANSLATE_USER where user_name='tony' and user_secret='1234'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();



            if (sdr.HasRows)
                Console.WriteLine("登录成功!", "提示");
            else
                Console.WriteLine("123");
        }
    }
}
