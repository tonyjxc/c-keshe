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

namespace frmWin.dorm
{
    public partial class dormViewForm : Form
    {
        public dormViewForm()
        {
            InitializeComponent();
        }
        /***************变量声明开始*************************/
        dormwsm wsm = new dormwsm();
        /***************变量声明结束*************************/
        private void dormViewForm_Load(object sender, EventArgs e)
        {
			//创建实体类接受页面上的id
			dorm d = new dorm();
			d.dormId = this.txtDormId.Text;
			//利用id查询到选中的所有信息
			DataTable dt = wsm.findById(d);
			//给页面上的lbl赋值
			this.txtDormId.Text = dt.Rows[0]["dormId"].ToString();
			this.txtDormNum.Text = dt.Rows[0]["dormNum"].ToString();
			this.txtPerson.Text = dt.Rows[0]["personCount"].ToString();
			this.txtMemo.Text = dt.Rows[0]["memo"].ToString();

			//处理Flag状态，使他成为文字显示
			if (dt.Rows[0]["flag"].ToString() == "1") this.txtFlag.Text = "可以入住";
			else if (dt.Rows[0]["flag"].ToString() == "2") this.txtFlag.Text = "不可入住";
			//处理类型外键
			DataTable dtt = wsm.findByType(d);
			this.txtType.Text = dtt.Rows[0]["typeName"].ToString();
			//处理楼层外键
			DataTable ddtt = wsm.findByBuild(d);
			this.txtBuilding.Text = ddtt.Rows[0]["buildName"].ToString();
			//从上到下打开窗口
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

        private void dormViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			SingleWindow.dvf = new dormViewForm();
		}
    }
}
