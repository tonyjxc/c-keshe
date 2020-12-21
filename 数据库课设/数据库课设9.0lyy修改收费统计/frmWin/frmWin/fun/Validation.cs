using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using keshe;
using System.Data;
using System.Data.SqlClient;
namespace frmWin.fun
{
    /// <summary>
    /// 这个类是专门用来进行文本校验的
    /// </summary>
    /// <param name="msg">待校验的变量名</param>
    /// <param name="info">自定义提示信息</param>
    /// <param name="lbl">定义声明了一个label，传递了一个空间</param>
    /// <returns>返回一个bool值</returns>
    class Validation
    {
		public static bool checktxt(string msg, ref string reply)
		{
			//判断文本框是否为空
			if (msg == "")
			{
				
				return true;
			}
			//IndexOf()查找字串中指定字符或字串首次出现的位置,返首索引值
			else if (msg.IndexOf('@') != -1)
			{
				reply = "不能填写特殊符号：@";
				return true;
			}
			else if (msg.IndexOf('!') != -1)
			{
				reply = "不能填写特殊符号：!";
				return true;
			}
			else if (msg.IndexOf('$') != -1)
			{
				reply = "不能填写特殊符号：$";
				return true;
			}
			else if (msg.IndexOf('?') != -1)
			{
				reply = "不能填写特殊符号：?";
				return true;
			}
			else if (msg.IndexOf('？') != -1)
			{
				reply = "不能填写特殊符号：？";
				return true;
			}
			else if (msg.IndexOf('。') != -1)
			{
				reply = "不能填写特殊符号：。";
				return true;
			}
			else if (msg.IndexOf('，') != -1)
			{
				reply = "不能填写特殊符号：，";
				return true;
			}
			else if (msg.IndexOf(',') != -1)
			{
				reply = "不能填写特殊符号：,";
				return true;
			}
			else if (msg.IndexOf('!') != -1)
			{
				reply = "不能填写特殊符号：。";
				return true;
			}
			else if (msg.IndexOf('\'') != -1)
			{
				reply = "不能填写特殊符号：\'";
				return true;
			}
			return false;
		}
		public static bool ValidateInt(ref string dormnum,int aa,int bb)
		{
			
			return Regex.IsMatch(dormnum, @"^[1-9]\d*\.?[0]*$");
		}
		public static bool checkDormNO(ref string dormnum)
		{
			SqlConnection conn = new SqlConnection("server=" + MyGlobal.ip + ";database=dormitory;UID=sa;PWD=zyh@197068;Integrated Security=False");
			conn.Open();
			string sqlquery1 = @"select dormNum from dormitory where dormNum='{0}'";
			sqlquery1 = string.Format(sqlquery1,dormnum);
			SqlCommand sql = new SqlCommand(sqlquery1, conn);
			SqlDataReader reader = sql.ExecuteReader();
			while (reader.Read()) 
			{
				dormintory.dormNum= Convert.ToString(reader["dormNum"]); //获取宿舍号。
				if (dormnum== dormintory.dormNum) return false; 
			}
			
			return true;
		}

	}
}
