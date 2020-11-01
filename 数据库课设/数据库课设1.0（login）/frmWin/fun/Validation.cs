using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
	}
}
