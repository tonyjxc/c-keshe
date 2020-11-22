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
    public partial class buildingManagerForm : Form
    {

        public buildingManagerForm()
        {
            InitializeComponent();
        }
        /*****************变量声明开始*******************************/
        buildingWSM wsm = new buildingWSM();
        PageHelper page = new PageHelper();
        /*****************变量声明结束*******************************/

        public void flush()
        {
            //创建实体类对象
            building t = new building();
            //处理界面参数
            t.buildName = this.txtDromName.Text;
            //查询总条数
            page.count = wsm.count(t);
            //将数据库中的内容显示到界面上
            this.dgvbuilding.DataSource = wsm.findAll(t, page);

            //给页面上的控件赋值
            this.lblPage.Text = "当前：" + page.nowPage + "页   共：" + page.getTotalPage() + "页  总计：" + page.count + "条";
        }

        private void buildingManagerForm_Load(object sender, EventArgs e)
        {
            //身份权限

            //调用刷新方法
            flush();
        }

        private void buildingManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingleWindow.bmf = new buildingManagerForm();
        }

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

        private void btnFind_Click(object sender, EventArgs e)
        {
            page.nowPage = 1;
            //调用刷新方法
            flush();
        }
    }
}
