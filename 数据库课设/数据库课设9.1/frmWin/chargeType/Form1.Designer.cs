
namespace frmWin.chargeType
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txttypeid = new System.Windows.Forms.TextBox();
            this.txttypeName = new System.Windows.Forms.TextBox();
            this.txtunitPrice = new System.Windows.Forms.TextBox();
            this.txtmemo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(252, 324);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 28);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(103, 324);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 28);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txttypeid
            // 
            this.txttypeid.Location = new System.Drawing.Point(158, 22);
            this.txttypeid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttypeid.Name = "txttypeid";
            this.txttypeid.Size = new System.Drawing.Size(216, 28);
            this.txttypeid.TabIndex = 25;
            // 
            // txttypeName
            // 
            this.txttypeName.Location = new System.Drawing.Point(158, 92);
            this.txttypeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttypeName.Name = "txttypeName";
            this.txttypeName.Size = new System.Drawing.Size(216, 28);
            this.txttypeName.TabIndex = 24;
            // 
            // txtunitPrice
            // 
            this.txtunitPrice.Location = new System.Drawing.Point(158, 167);
            this.txtunitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtunitPrice.Name = "txtunitPrice";
            this.txtunitPrice.Size = new System.Drawing.Size(216, 28);
            this.txtunitPrice.TabIndex = 23;
            // 
            // txtmemo
            // 
            this.txtmemo.Location = new System.Drawing.Point(158, 242);
            this.txtmemo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmemo.Name = "txtmemo";
            this.txtmemo.Size = new System.Drawing.Size(216, 28);
            this.txtmemo.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "主键";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "费用名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "价格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "备注";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 496);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txttypeid);
            this.Controls.Add(this.txttypeName);
            this.Controls.Add(this.txtunitPrice);
            this.Controls.Add(this.txtmemo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "费用信息插入";
            this.Load += new System.EventHandler(this.dormTypeInsertFrm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdoWoman;
        private System.Windows.Forms.RadioButton rdoMan;
        public System.Windows.Forms.TextBox txttypeid;
        public System.Windows.Forms.TextBox txttypeName;
        public System.Windows.Forms.TextBox txtunitPrice;
        public System.Windows.Forms.TextBox txtmemo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}