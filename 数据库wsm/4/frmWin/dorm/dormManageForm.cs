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
using frmWin.dormType;

namespace frmWin.dorm
{
    public partial class dormManageForm : Form
    {
        public dormManageForm()
        {
            InitializeComponent();
        }
        /***************变量声明开始*************************/
        dormwsm wsm = new dormwsm();
		PageHelper page = new PageHelper();
		/***************变量声明结束*************************/
		public void flush()
		{
			//创建实体类对象
			dorm d = new dorm();
			//处理界面参数
			d.dormNum = this.txtTypeName.Text;
			//d.flag = "1";
			if (this.cboFlag.Text == "可以入住") d.flag = "1";
			else if (this.cboFlag.Text == "不可入住") d.flag = "2";
			
			page.count = wsm.count(d);
			//将数据库中的内容显示到界面上
			this.dgvTeacher.DataSource = wsm.findAll(d, page);

			//给页面上的控件赋值
			this.lblPage.Text = "当前：" + page.nowPage + "页   共：" + page.getTotalPage() + "页  总计：" + page.count + "条";
		}

        private void dormManageForm_Load(object sender, EventArgs e)
        {
			this.cboFlag.Text = "可以入住";
			//调用刷新方法
			flush();
			//从上到下打开窗口
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
		//关闭后创建新的窗体
		private void dormManageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			SingleWindow.dmf = new dormManageForm();
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

        private void btnLast_Click(object sender, EventArgs e)
        {
			page.nowPage = page.getTotalPage();
			//调用刷新方法
			flush();
		}
    }
}
