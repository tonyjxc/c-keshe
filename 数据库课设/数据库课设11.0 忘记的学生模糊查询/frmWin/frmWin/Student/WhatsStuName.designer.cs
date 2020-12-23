namespace frmWin.Student
{
    partial class WhatsStuName
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
            this.label1 = new System.Windows.Forms.Label();
            this.chooseteacher = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stuname = new System.Windows.Forms.TextBox();
            this.enteryear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.stufullname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(210, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "我来帮你查询记忆中丢失的同学的！";
            // 
            // chooseteacher
            // 
            this.chooseteacher.Font = new System.Drawing.Font("宋体", 20F);
            this.chooseteacher.FormattingEnabled = true;
            this.chooseteacher.Location = new System.Drawing.Point(192, 84);
            this.chooseteacher.Name = "chooseteacher";
            this.chooseteacher.Size = new System.Drawing.Size(140, 35);
            this.chooseteacher.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 20F);
            this.label5.Location = new System.Drawing.Point(80, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "老师：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(26, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "学生姓氏：";
            // 
            // stuname
            // 
            this.stuname.Font = new System.Drawing.Font("宋体", 20F);
            this.stuname.Location = new System.Drawing.Point(192, 147);
            this.stuname.Name = "stuname";
            this.stuname.Size = new System.Drawing.Size(140, 38);
            this.stuname.TabIndex = 26;
            this.stuname.TextChanged += new System.EventHandler(this.stuname_TextChanged);
            // 
            // enteryear
            // 
            this.enteryear.Font = new System.Drawing.Font("宋体", 20F);
            this.enteryear.Location = new System.Drawing.Point(192, 214);
            this.enteryear.Name = "enteryear";
            this.enteryear.Size = new System.Drawing.Size(140, 38);
            this.enteryear.TabIndex = 27;
            this.enteryear.TextChanged += new System.EventHandler(this.enteryear_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.Location = new System.Drawing.Point(26, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "入学年份：";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("宋体", 20F);
            this.submit.Location = new System.Drawing.Point(505, 325);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(88, 48);
            this.submit.TabIndex = 29;
            this.submit.Text = "查询";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // stufullname
            // 
            this.stufullname.Font = new System.Drawing.Font("宋体", 20F);
            this.stufullname.FormattingEnabled = true;
            this.stufullname.Location = new System.Drawing.Point(533, 147);
            this.stufullname.Name = "stufullname";
            this.stufullname.Size = new System.Drawing.Size(176, 35);
            this.stufullname.TabIndex = 30;
            this.stufullname.Text = "等待查询";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 20F);
            this.label4.Location = new System.Drawing.Point(380, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 31;
            this.label4.Text = "或许是我：";
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("宋体", 20F);
            this.quit.Location = new System.Drawing.Point(621, 325);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(88, 48);
            this.quit.TabIndex = 32;
            this.quit.Text = "退出";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // WhatsStuName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stufullname);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enteryear);
            this.Controls.Add(this.stuname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chooseteacher);
            this.Controls.Add(this.label1);
            this.Name = "WhatsStuName";
            this.Text = "WhatsStuName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseteacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stuname;
        private System.Windows.Forms.TextBox enteryear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox stufullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button quit;
    }
}