
namespace frmWin.teacher
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
            this.rdoWoman = new System.Windows.Forms.RadioButton();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.txtteachId = new System.Windows.Forms.TextBox();
            this.txtteachPass = new System.Windows.Forms.TextBox();
            this.txtteachUserName = new System.Windows.Forms.TextBox();
            this.txtteachName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(289, 376);
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
            this.btnSubmit.Location = new System.Drawing.Point(158, 376);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 28);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdoWoman
            // 
            this.rdoWoman.AutoSize = true;
            this.rdoWoman.Location = new System.Drawing.Point(294, 242);
            this.rdoWoman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoWoman.Name = "rdoWoman";
            this.rdoWoman.Size = new System.Drawing.Size(51, 22);
            this.rdoWoman.TabIndex = 27;
            this.rdoWoman.TabStop = true;
            this.rdoWoman.Text = "女";
            this.rdoWoman.UseVisualStyleBackColor = true;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Location = new System.Drawing.Point(158, 247);
            this.rdoMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(51, 22);
            this.rdoMan.TabIndex = 26;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // txtteachId
            // 
            this.txtteachId.Location = new System.Drawing.Point(158, 296);
            this.txtteachId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtteachId.Name = "txtteachId";
            this.txtteachId.Size = new System.Drawing.Size(216, 28);
            this.txtteachId.TabIndex = 25;
            // 
            // txtteachPass
            // 
            this.txtteachPass.Location = new System.Drawing.Point(158, 167);
            this.txtteachPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtteachPass.Name = "txtteachPass";
            this.txtteachPass.Size = new System.Drawing.Size(216, 28);
            this.txtteachPass.TabIndex = 24;
            // 
            // txtteachUserName
            // 
            this.txtteachUserName.Location = new System.Drawing.Point(158, 106);
            this.txtteachUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtteachUserName.Name = "txtteachUserName";
            this.txtteachUserName.Size = new System.Drawing.Size(216, 28);
            this.txtteachUserName.TabIndex = 23;
            // 
            // txtteachName
            // 
            this.txtteachName.Location = new System.Drawing.Point(158, 58);
            this.txtteachName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtteachName.Name = "txtteachName";
            this.txtteachName.Size = new System.Drawing.Size(216, 28);
            this.txtteachName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "主键";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "生日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "姓名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 496);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdoWoman);
            this.Controls.Add(this.rdoMan);
            this.Controls.Add(this.txtteachId);
            this.Controls.Add(this.txtteachPass);
            this.Controls.Add(this.txtteachUserName);
            this.Controls.Add(this.txtteachName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "教师信息插入";
            this.Load += new System.EventHandler(this.dormTypeInsertFrm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdoWoman;
        private System.Windows.Forms.RadioButton rdoMan;
        public System.Windows.Forms.TextBox txtteachId;
        public System.Windows.Forms.TextBox txtteachPass;
        public System.Windows.Forms.TextBox txtteachUserName;
        public System.Windows.Forms.TextBox txtteachName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}