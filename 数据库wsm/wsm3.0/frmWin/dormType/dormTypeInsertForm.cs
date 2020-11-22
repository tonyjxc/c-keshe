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
    public partial class dormTypeInsertForm : Form
    {
        public dormTypeInsertForm()
        {
            InitializeComponent();
        }
        /***************变量声明开始*************************/
        dormTypeWSM wsm = new dormTypeWSM();
        /***************变量声明结束*************************/
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //接收界面参数
            dormType t = new dormType();
            t.typeName = this.txtTypeName.Text;
            string reply1 = "亲，类型名不能为空哦！";
            string reply2 = "亲，人数不能为空哦！";
            string reply3 = "亲，价格不能为空哦！";

            if (Validation.checktxt(t.typeName, ref reply1)) return;
            t.personCount = this.txtPersonCount.Text;
            if (Validation.checktxt(t.personCount, ref reply2)) return;
            t.price = this.txtPrice.Text;
            if (Validation.checktxt(t.price, ref reply3)) return;
            string sex = "";
            if (rdoMan.Checked) sex = "男";
            else if (rdoWoman.Checked) sex = "女";
            t.sex = sex;
            t.memeo = this.txtMemo.Text;
            DataTable dt = wsm.findTypeName(this.txtTypeName.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("该类型已存在！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //添加进数据库
                wsm.insert(t);
                //关闭当前窗体
                this.Close();
                MessageBox.Show("添加成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        /// <summary>
        /// 取消按钮点击事件
		/// 跳出新的窗体进行询问
		/// 选择yes的时候关闭当前窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出么？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dr)
            {
                this.Close();
            }
        }
        /// <summary>
        /// 关闭当前窗体后自动创建一个新的窗体对象，便于下次使用
		/// 可以多次打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dormTypeInsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingleWindow.dtif=new dormTypeInsertForm();
        }
    }
}
