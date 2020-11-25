using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmWin.fun
{
   
    class PageHelper
    {
		public int pageSize = 3;//每页显示几条数据
		public int nowPage = 1;//当前页
		public int count = 0;//总条数
		public int getBegin()
		{
			return (nowPage - 1) * pageSize;
		}
		public int getTotalPage()
		{
			return this.count % this.pageSize == 0 ? this.count / this.pageSize :
				this.count / this.pageSize + 1;
		}
	}
}
