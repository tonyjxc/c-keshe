using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmWin.chargeType
{
	class Class1
	{
		//类型编号 主键，自增 方便于查询类型名称
		public string typeid;
		//类型名称 varchar型 用来贮存宿舍类型的名称，可重复
		public string typeName;
		//人数 varchar型 
		public string unitPrice;
		
		//备注 varchar型
		public string memo;
	}
}
