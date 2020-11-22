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

namespace frmWin.building
{
    public partial class buildingInsertForm : Form
    {
        public buildingInsertForm()
        {
            InitializeComponent();
        }
        /***************变量声明开始*************************/
        buildingWSM wsm = new buildingWSM();
        /***************变量声明结束*************************/

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //接收界面参数
            building t = new building();
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
            //添加进数据库
            wsm.insert(t);
            
            //刷新manager窗体的dgv
            //等老师创建了之后
            //SingleWindow.ttmf.flush();


            //关闭当前窗体
            this.Close();
            MessageBox.Show("添加成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出么？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dr)
            {
                this.Close();
            }
        }

        private void buildingInsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingleWindow.bif = new buildingInsertForm();
        }
    }
}
