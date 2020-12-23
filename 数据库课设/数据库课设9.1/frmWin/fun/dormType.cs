using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmWin.fun
{
    /// <summary>
    /// 实体类，跟数据库中的dormType表相对应
	/// 方便于之后的储存数据
    /// </summary>
    class dormType
    {
		//类型编号 主键，自增 方便于查询类型名称
		public string typeId;
		//类型名称 varchar型 用来贮存宿舍类型的名称，可重复
		public string typeName;
		//人数 varchar型 
		public string personCount;
		//价格 decimal型
		public string price;
		//状态 int型
		public string flag;
		//性别 char型
		public string sex;
		//备注 varchar型
		public string memeo;
	}
}
