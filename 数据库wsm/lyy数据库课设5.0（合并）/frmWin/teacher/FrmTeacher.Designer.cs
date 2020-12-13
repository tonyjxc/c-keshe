namespace frmWin.teacher
{
    partial class FrmTeacher
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.specialty = new System.Windows.Forms.Label();
            this.telnum = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.teachnum = new System.Windows.Forms.Label();
            this.CreateTime = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExit.Location = new System.Drawing.Point(771, 322);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 32);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.deleteBtn.Location = new System.Drawing.Point(602, 322);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(88, 32);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "修改";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "教师编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "性别";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15F);
            this.label9.Location = new System.Drawing.Point(397, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "专业";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(397, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(397, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "电话";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(3, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 30);
            this.label6.TabIndex = 23;
            this.label6.Text = "雇佣日期";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.32813F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.67188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel1.Controls.Add(this.specialty, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.telnum, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sex, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.name, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.teachnum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CreateTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 56);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.32743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.67257F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 231);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // specialty
            // 
            this.specialty.AutoSize = true;
            this.specialty.Font = new System.Drawing.Font("宋体", 15F);
            this.specialty.Location = new System.Drawing.Point(525, 152);
            this.specialty.Name = "specialty";
            this.specialty.Size = new System.Drawing.Size(73, 30);
            this.specialty.TabIndex = 32;
            this.specialty.Text = "null";
            // 
            // telnum
            // 
            this.telnum.AutoSize = true;
            this.telnum.Font = new System.Drawing.Font("宋体", 15F);
            this.telnum.Location = new System.Drawing.Point(525, 78);
            this.telnum.Name = "telnum";
            this.telnum.Size = new System.Drawing.Size(73, 30);
            this.telnum.TabIndex = 31;
            this.telnum.Text = "null";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("宋体", 15F);
            this.sex.Location = new System.Drawing.Point(146, 78);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(73, 30);
            this.sex.TabIndex = 30;
            this.sex.Text = "null";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("宋体", 15F);
            this.name.Location = new System.Drawing.Point(525, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 30);
            this.name.TabIndex = 29;
            this.name.Text = "null";
            // 
            // teachnum
            // 
            this.teachnum.AutoSize = true;
            this.teachnum.Font = new System.Drawing.Font("宋体", 15F);
            this.teachnum.Location = new System.Drawing.Point(146, 0);
            this.teachnum.Name = "teachnum";
            this.teachnum.Size = new System.Drawing.Size(73, 30);
            this.teachnum.TabIndex = 28;
            this.teachnum.Text = "null";
            // 
            // CreateTime
            // 
            this.CreateTime.CalendarFont = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CreateTime.Location = new System.Drawing.Point(147, 156);
            this.CreateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Size = new System.Drawing.Size(232, 28);
            this.CreateTime.TabIndex = 27;
            this.CreateTime.Value = new System.DateTime(2020, 11, 15, 19, 55, 0, 0);
            // 
            // FrmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 404);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmTeacher";
            this.Load += new System.EventHandler(this.FrmTeacher_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label specialty;
        private System.Windows.Forms.Label telnum;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label teachnum;
        private System.Windows.Forms.DateTimePicker CreateTime;
    }
}