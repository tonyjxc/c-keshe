using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace frmWin.teacher
{
	class Class1
	{
		//类型编号 主键，自增 方便于查询类型名称
		public string teachId;
		//类型名称 varchar型 用来贮存宿舍类型的名称，可重复
		public string teachName;
		//人数 varchar型 
		public string teachUserName;
		//价格 decimal型
		public string teachPass;
		//性别 char型
		public string sex;
		//备注 varchar型
		public string memeo;
	}
}