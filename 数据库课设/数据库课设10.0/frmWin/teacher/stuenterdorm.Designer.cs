namespace frmWin.teacher
{
    partial class stuenterdorm
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
            this.chooseclass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.choosestudent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chooseteacher = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dormtype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sexlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dormremainlabel = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.ComboBox();
            this.dormnum = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.remianlabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(849, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "功能！！连接查询没有宿舍的学生，同时分配宿舍的时候保证楼宿舍使用数、宿舍人数符合！！";
            // 
            // chooseclass
            // 
            this.chooseclass.Font = new System.Drawing.Font("宋体", 20F);
            this.chooseclass.FormattingEnabled = true;
            this.chooseclass.Location = new System.Drawing.Point(361, 90);
            this.chooseclass.Name = "chooseclass";
            this.chooseclass.Size = new System.Drawing.Size(191, 35);
            this.chooseclass.TabIndex = 17;
            this.chooseclass.SelectedIndexChanged += new System.EventHandler(this.chooseclass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(289, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "班级";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(27, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(649, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "功能！！宿舍种类选择的连接查询！！选择老师的连接查询！！........";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 20F);
            this.label4.Location = new System.Drawing.Point(615, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "学生";
            // 
            // choosestudent
            // 
            this.choosestudent.Font = new System.Drawing.Font("宋体", 20F);
            this.choosestudent.FormattingEnabled = true;
            this.choosestudent.Location = new System.Drawing.Point(687, 90);
            this.choosestudent.Name = "choosestudent";
            this.choosestudent.Size = new System.Drawing.Size(155, 35);
            this.choosestudent.TabIndex = 20;
            this.choosestudent.SelectedIndexChanged += new System.EventHandler(this.choosestudent_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 20F);
            this.label5.Location = new System.Drawing.Point(26, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "老师";
            // 
            // chooseteacher
            // 
            this.chooseteacher.Font = new System.Drawing.Font("宋体", 20F);
            this.chooseteacher.FormattingEnabled = true;
            this.chooseteacher.Location = new System.Drawing.Point(107, 90);
            this.chooseteacher.Name = "chooseteacher";
            this.chooseteacher.Size = new System.Drawing.Size(140, 35);
            this.chooseteacher.TabIndex = 22;
            this.chooseteacher.SelectedIndexChanged += new System.EventHandler(this.chooseteacher_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 20F);
            this.label6.Location = new System.Drawing.Point(26, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "宿舍种类";
            // 
            // dormtype
            // 
            this.dormtype.Font = new System.Drawing.Font("宋体", 20F);
            this.dormtype.FormattingEnabled = true;
            this.dormtype.Location = new System.Drawing.Point(161, 189);
            this.dormtype.Name = "dormtype";
            this.dormtype.Size = new System.Drawing.Size(184, 35);
            this.dormtype.TabIndex = 25;
            this.dormtype.SelectedIndexChanged += new System.EventHandler(this.dormtype_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(36, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "性别：";
            // 
            // sexlabel
            // 
            this.sexlabel.AutoSize = true;
            this.sexlabel.Font = new System.Drawing.Font("宋体", 12F);
            this.sexlabel.Location = new System.Drawing.Point(104, 151);
            this.sexlabel.Name = "sexlabel";
            this.sexlabel.Size = new System.Drawing.Size(120, 16);
            this.sexlabel.TabIndex = 27;
            this.sexlabel.Text = "选后会显示！！";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 20F);
            this.label9.Location = new System.Drawing.Point(376, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 27);
            this.label9.TabIndex = 28;
            this.label9.Text = "楼";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(378, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "楼内剩余：";
            // 
            // dormremainlabel
            // 
            this.dormremainlabel.AutoSize = true;
            this.dormremainlabel.Font = new System.Drawing.Font("宋体", 12F);
            this.dormremainlabel.Location = new System.Drawing.Point(472, 250);
            this.dormremainlabel.Name = "dormremainlabel";
            this.dormremainlabel.Size = new System.Drawing.Size(120, 16);
            this.dormremainlabel.TabIndex = 30;
            this.dormremainlabel.Text = "选后会显示！！";
            // 
            // building
            // 
            this.building.Font = new System.Drawing.Font("宋体", 20F);
            this.building.FormattingEnabled = true;
            this.building.Location = new System.Drawing.Point(421, 189);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(131, 35);
            this.building.TabIndex = 31;
            this.building.SelectedIndexChanged += new System.EventHandler(this.building_SelectedIndexChanged);
            // 
            // dormnum
            // 
            this.dormnum.Font = new System.Drawing.Font("宋体", 20F);
            this.dormnum.FormattingEnabled = true;
            this.dormnum.Location = new System.Drawing.Point(714, 189);
            this.dormnum.Name = "dormnum";
            this.dormnum.Size = new System.Drawing.Size(128, 35);
            this.dormnum.TabIndex = 35;
            this.dormnum.SelectedIndexChanged += new System.EventHandler(this.dormnum_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 20F);
            this.label13.Location = new System.Drawing.Point(615, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 27);
            this.label13.TabIndex = 34;
            this.label13.Text = "宿舍号";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExit.Location = new System.Drawing.Point(770, 329);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 26);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(665, 329);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(59, 26);
            this.btnSubmit.TabIndex = 36;
            this.btnSubmit.Text = "分配";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // remianlabel
            // 
            this.remianlabel.AutoSize = true;
            this.remianlabel.Font = new System.Drawing.Font("宋体", 12F);
            this.remianlabel.Location = new System.Drawing.Point(722, 250);
            this.remianlabel.Name = "remianlabel";
            this.remianlabel.Size = new System.Drawing.Size(120, 16);
            this.remianlabel.TabIndex = 39;
            this.remianlabel.Text = "选后会显示！！";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F);
            this.label14.Location = new System.Drawing.Point(628, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "寝室剩余：";
            // 
            // stuenterdorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 443);
            this.Controls.Add(this.remianlabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dormnum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.building);
            this.Controls.Add(this.dormremainlabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sexlabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dormtype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chooseteacher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.choosestudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseclass);
            this.Controls.Add(this.label1);
            this.Name = "stuenterdorm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "stuenterdorm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox choosestudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox chooseteacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dormtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sexlabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label dormremainlabel;
        private System.Windows.Forms.ComboBox building;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label remianlabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox chooseclass;
        private System.Windows.Forms.ComboBox dormnum;
    }
}