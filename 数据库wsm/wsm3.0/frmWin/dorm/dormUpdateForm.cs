using frmWin.dormType;
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
    public partial class dormUpdateForm : Form
    {
        public dormUpdateForm()
        {
            InitializeComponent();
        }
        /***************变量声明开始*************************/
        dormwsm wsm = new dormwsm();
        dormTypeWSM typeDao = new dormTypeWSM();
        dormwsm dwsm = new dormwsm();
        /***************变量声明结束*************************/
        private void btnSubmit_Click(object sender, EventArgs e)
        {
			//接受页面文本框参数
			dorm d = new dorm();
			d.dormId = this.txtDormId.Text;
			string reply1 = "亲，宿舍名不能为空哦！";
			string reply2 = "亲，人数不能为空哦！";
			string reply3 = "亲，价格不能为空哦！";
			if (this.cboFlag.Text == "可以入住") d.flag = "1";
			else if (this.cboFlag.Text == "不可入住") d.flag = "2";
			d.memo = this.txtMemo.Text;
			//处理下拉框（外键）
			d.fk_typeId = this.cboDormType.SelectedValue.ToString();
			d.fk_buildId = this.cboBuilding.SelectedValue.ToString();
			d.dormNum = this.txtDormNum.Text;
			d.personCount = this.txtPersonCount.Text;
			if (Validation.checktxt(d.dormNum, ref reply1)) return;
			if (Validation.checktxt(d.personCount, ref reply2)) return;
			//把修改后的数据加入数据库
			wsm.update(d);
			//刷新manager窗体的dgv
			SingleWindow.dmf.flush();
			//关闭当前窗体
			this.Close();
			MessageBox.Show("修改成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

		}

        private void dormUpdateForm_Load(object sender, EventArgs e)
        {
			//把从数据库中查询到的所有下拉框的值赋值

			this.cboBuilding.DataSource = dwsm.queryBuildAll().DefaultView;
			//MessageBox.Show(this.cboBuilding.DataSource.ToString());
			//给程序员看的编号
			this.cboBuilding.ValueMember = "buildId";
			this.cboBuilding.DisplayMember = "buildName";
			this.cboFlag.Text = "可以入住";
			//MessageBox.Show(this.cboBuilding.ValueMember);
			//给用户看的名称
			//增强用户体验
			this.cboDormType.DataSource = typeDao.queryAll().DefaultView;
			//给程序员看的id
			this.cboDormType.ValueMember = "typeId";
			//给用户看的类型名称
			this.cboDormType.DisplayMember = "typeName";
			//从上到下打开窗口
		}

		//关闭后创建一个新的窗体对象
		//方便下一次使用
		private void dormUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			SingleWindow.duf = new dormUpdateForm();
		}

		/// <summary>
		/// 关闭按钮点击事件
		/// 单击后询问用户是否关闭
		/// 根据用户需要进行操作
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExit_Click(object sender, EventArgs e)
        {
			DialogResult dr = MessageBox.Show("确定要关闭么？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (DialogResult.Yes == dr)
			{
				this.Close();
			}
		}
    }
}
