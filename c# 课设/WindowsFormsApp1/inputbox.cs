using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class inputbox : Form
    {
        public String inputthings;
        public inputbox(String question)
        {
            InitializeComponent();
            this.label1.Text = "现在来尝试翻译一下" + question + "吧";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.inputthings = input_txt.Text;
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();
        }
    }
}
