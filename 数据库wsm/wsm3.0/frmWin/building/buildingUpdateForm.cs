using frmWin.fun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmWin.building
{
    public partial class buildingUpdateForm : Form
    {
        public buildingUpdateForm()
        {
            InitializeComponent();
        }
        buildingWSM wsm = new buildingWSM();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
			//接收界面参数
			building t = new building();
			t.buildId = int.Parse(this.txtTypeId.Text);
			t.buildName = this.txtTypeName.Text;
			t.dormCount = this.txtMemo.Text;
			t.dromFloor = this.txtdormFloor.Text;
            string reply1 = "亲，楼层名不能为空哦！";
            string reply2 = "亲，人数不能为空哦！";
            string reply3 = "亲，所在楼层不能为空哦！";
            //文本框校验
            if (Validation.checktxt(t.buildName, ref reply1)) return;
            if (Validation.checktxt(t.dormCount, ref reply2)) return;
            if (Validation.checktxt(t.dromFloor, ref reply3)) return;
            wsm.update(t);
			
            //刷新manager窗体的dgv
			//SingleWindow.ttmf.flush();
			
            //关闭当前窗体
			this.Close();
			MessageBox.Show("修改成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出么？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dr)
            {
                this.Close();
            }
        }

        private void buildingUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingleWindow.buf = new buildingUpdateForm();
        }
    }
}
