using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using keshe;
using frmWin.fun;

namespace frmWin.dormType
{
    public partial class dormTypeManageForm : Form
    {
        public dormTypeManageForm()
        {
            InitializeComponent();
        }
        dormTypeWSM wsm = new dormTypeWSM();
        PageHelper page = new PageHelper();

		public void flush()
		{
			//创建实体类对象
			dormType t = new dormType();
			//处理界面参数
			t.typeName = this.txtTeachTypeName.Text;
			//查询总条数
			page.count = wsm.count(t);
			DataTable dt = wsm.findAll(t, page);
			//将数据库中的内容显示到界面上
			this.dgvTeachType.DataSource = dt;
			//给页面上的控件赋值
			this.lblPage.Text = "当前：" + page.nowPage + "页   共：" + page.getTotalPage() + "页  总计：" + page.count + "条";
		}

        private void dormTypeManageForm_Load(object sender, EventArgs e)
        {
			flush();
		}
		/// <summary>
		/// 查询点击事件
		/// 根据用户输入的值进行查询
		/// 得到用户所需要的数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFind_Click(object sender, EventArgs e)
        {
			page.nowPage = 1;
			//调用刷新方法
			flush();
		}
		/// <summary>
		/// 关闭后创建新的窗体
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dormTypeManageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			SingleWindow.dtmf = new dormTypeManageForm();
		}
		/// <summary>
		/// 首页点击事件
		/// 点击进入所有数据第一页
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFirst_Click(object sender, EventArgs e)
        {
			//当前页
			page.nowPage = 1;
			//调用刷新方法
			flush();
		}
		/// <summary>
		/// 上一页点击事件
		/// 点击进入当前页的相对上一页
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPrev_Click(object sender, EventArgs e)
        {
			page.nowPage--;
			if (page.nowPage < 1)
			{
				MessageBox.Show("已经是第一页了！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				page.nowPage = 1;
			}
			//调用刷新方法
			flush();
		}
		/// <summary>
		/// 下一页点击事件
		/// 点击进入当前页的相对下一页
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnNext_Click(object sender, EventArgs e)
        {
			page.nowPage++;
			if (page.nowPage >= page.getTotalPage())
			{
				MessageBox.Show("已经是最后一页了！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				page.nowPage = page.getTotalPage();
			}
			//调用刷新方法
			flush();
		}
		/// <summary>
		/// 尾页点击事件
		/// 点击进入所有数据第一页
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnLast_Click(object sender, EventArgs e)
        {
			page.nowPage = page.getTotalPage();
			//调用刷新方法
			flush();
		}
    }
}
