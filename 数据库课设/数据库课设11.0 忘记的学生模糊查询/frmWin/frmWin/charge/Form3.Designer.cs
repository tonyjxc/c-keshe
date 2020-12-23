
namespace frmWin.charge
{
    partial class Form3
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
            this.rdoWoman = new System.Windows.Forms.RadioButton();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.txtchargeId = new System.Windows.Forms.TextBox();
            this.txtchargeName = new System.Windows.Forms.TextBox();
            this.txtfk_stuId = new System.Windows.Forms.TextBox();
            this.txtfk_teachId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(252, 355);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 28);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(118, 355);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 28);
            this.btnSubmit.TabIndex = 43;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdoWoman
            // 
            this.rdoWoman.AutoSize = true;
            this.rdoWoman.Location = new System.Drawing.Point(306, 271);
            this.rdoWoman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoWoman.Name = "rdoWoman";
            this.rdoWoman.Size = new System.Drawing.Size(87, 22);
            this.rdoWoman.TabIndex = 42;
            this.rdoWoman.TabStop = true;
            this.rdoWoman.Text = "支付宝";
            this.rdoWoman.UseVisualStyleBackColor = true;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Location = new System.Drawing.Point(170, 276);
            this.rdoMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(69, 22);
            this.rdoMan.TabIndex = 41;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "微信";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // txtchargeId
            // 
            this.txtchargeId.Location = new System.Drawing.Point(170, 86);
            this.txtchargeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtchargeId.Name = "txtchargeId";
            this.txtchargeId.Size = new System.Drawing.Size(216, 28);
            this.txtchargeId.TabIndex = 37;
            // 
            // txtchargeName
            // 
            this.txtchargeName.Location = new System.Drawing.Point(170, 41);
            this.txtchargeName.Name = "txtchargeName";
            this.txtchargeName.Size = new System.Drawing.Size(216, 28);
            this.txtchargeName.TabIndex = 0;
            // 
            // txtfk_stuId
            // 
            this.txtfk_stuId.Location = new System.Drawing.Point(170, 134);
            this.txtfk_stuId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfk_stuId.Name = "txtfk_stuId";
            this.txtfk_stuId.Size = new System.Drawing.Size(216, 28);
            this.txtfk_stuId.TabIndex = 38;
            // 
            // txtfk_teachId
            // 
            this.txtfk_teachId.Location = new System.Drawing.Point(170, 196);
            this.txtfk_teachId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfk_teachId.Name = "txtfk_teachId";
            this.txtfk_teachId.Size = new System.Drawing.Size(216, 28);
            this.txtfk_teachId.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "支付方式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "教师Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "学生Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "主键";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "费用名称";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdoWoman);
            this.Controls.Add(this.rdoMan);
            this.Controls.Add(this.txtchargeId);
            this.Controls.Add(this.txtchargeName);
            this.Controls.Add(this.txtfk_stuId);
            this.Controls.Add(this.txtfk_teachId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "费用类型修改";
            this.Load += new System.EventHandler(this.dormTypeUpdateFrm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdoWoman;
        private System.Windows.Forms.RadioButton rdoMan;

        public System.Windows.Forms.TextBox txtchargeId;
        public System.Windows.Forms.TextBox txtchargeName;
        public System.Windows.Forms.TextBox txtfk_stuId;
        public System.Windows.Forms.TextBox txtfk_teachId;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}