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
    public partial class dormInsertForm : Form
    {
        public dormInsertForm()
        {
            InitializeComponent();
        }
        /***************变量声明开始*************************/
        dormwsm wsm = new dormwsm();
        dormTypeWSM dormTypeWSM = new dormTypeWSM();
        /***************变量声明结束*************************/
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //接受页面文本框参数
            dorm d = new dorm();
            d.dormNum = this.txtDormNum.Text;
            string reply1 = "亲，宿舍名不能为空哦！";
            d.fk_typeId = this.cboDormType.SelectedValue.ToString();
            d.fk_buildId = this.cboBuilding.SelectedValue.ToString();
            if (Validation.checktxt(d.dormNum, ref reply1)) return;

            //处理宿舍状态下拉框
            if (this.cboFlag.Text == "可以入住") d.flag = "1";
            else if (this.cboFlag.Text == "不可入住") d.flag = "2";
            //添加进数据库
            wsm.insert(d);
            //刷新dmf窗体数据
            SingleWindow.dmf.flush();
            //关闭本窗体
            this.Close();
            MessageBox.Show("添加成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        /// <summary>
        /// 关闭窗体后创建一个新的窗体对象
		/// 方便下次使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dormInsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingleWindow.dif = new dormInsertForm();
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

        //窗体加载时执行事件
        private void dormInsertForm_Load(object sender, EventArgs e)
        {
            this.cboFlag.Text = "可以入住";
            DataTable dt = wsm.findByDormType();
            this.cboDormType.DataSource = dt.DefaultView;
            //给程序员使用的
            this.cboDormType.ValueMember = "typeid";
            //给用户看的
            this.cboDormType.DisplayMember = "typename";
            //处理宿舍楼下拉框，给它传值
            this.cboBuilding.DataSource = wsm.findByBuilding().DefaultView;
            //给程序员使用的
            this.cboBuilding.ValueMember = "buildId";
            //给用户看的
            this.cboBuilding.DisplayMember = "buildName";
            //从上到下打开窗口
        }
    }
}
