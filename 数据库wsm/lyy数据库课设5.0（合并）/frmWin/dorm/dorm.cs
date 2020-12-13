using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmWin.dorm
{
    /// <summary>
    /// 实体类，跟数据库中的dorm表相对应
	/// 方便于之后的储存数据
    /// </summary>
    class dorm
    {
		//主键 自增 宿舍编号
		//利于查询宿舍名称
		public string dormId;
		//宿舍门牌号 varchar型
		public string dormNum;
		//外键 宿舍类型编号 int型
		public string fk_typeId;
		//外键 楼层编号 int型
		public string fk_buildId;
		//宿舍人数 int 型
		public string personCount;
		//宿舍状态 int型 有床位  无床位
		public string flag;
		//备注 varchar型
		public string memo;
	}
}
