using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmWin.building
{
	/// <summary>
	/// 实体类，跟数据库中的building表相对应
	/// 方便于之后的储存数据
	/// </summary>
	class building
    {
		//宿舍楼编号 主键，自增 方便于查询宿舍名称
		public int buildId;
		//宿舍楼名称 int型 用来贮存宿舍的名称，可重复
		public string buildName;
		//宿舍总数 int型 
		public string dormCount;
		//宿舍总床位 int型
		public string dromFloor;
	}
}
