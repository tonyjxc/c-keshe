﻿namespace frmWin.teacher
{
    partial class ChangeTeachInfo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.specialty = new System.Windows.Forms.TextBox();
            this.telnum = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.teachnum = new System.Windows.Forms.Label();
            this.wrongtips = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExit.Location = new System.Drawing.Point(501, 229);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 34);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.deleteBtn.Location = new System.Drawing.Point(388, 229);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(59, 34);
            this.deleteBtn.TabIndex = 31;
            this.deleteBtn.Text = "提交";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.32813F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.67188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.teachnum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.specialty, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.telnum, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sex, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.name, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CreateTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.32743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.67257F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 165);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // specialty
            // 
            this.specialty.Font = new System.Drawing.Font("宋体", 12F);
            this.specialty.Location = new System.Drawing.Point(352, 114);
            this.specialty.Margin = new System.Windows.Forms.Padding(2);
            this.specialty.Name = "specialty";
            this.specialty.Size = new System.Drawing.Size(140, 26);
            this.specialty.TabIndex = 35;
            // 
            // telnum
            // 
            this.telnum.Font = new System.Drawing.Font("宋体", 12F);
            this.telnum.Location = new System.Drawing.Point(352, 59);
            this.telnum.Margin = new System.Windows.Forms.Padding(2);
            this.telnum.Name = "telnum";
            this.telnum.Size = new System.Drawing.Size(140, 26);
            this.telnum.TabIndex = 34;
            this.telnum.TextChanged += new System.EventHandler(this.telnum_TextChanged);
            // 
            // sex
            // 
            this.sex.Font = new System.Drawing.Font("宋体", 12F);
            this.sex.Location = new System.Drawing.Point(98, 59);
            this.sex.Margin = new System.Windows.Forms.Padding(2);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(140, 26);
            this.sex.TabIndex = 33;
            this.sex.TextChanged += new System.EventHandler(this.sex_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("宋体", 12F);
            this.name.Location = new System.Drawing.Point(352, 2);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(140, 26);
            this.name.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "教师编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(2, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "性别";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15F);
            this.label9.Location = new System.Drawing.Point(267, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "专业";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(267, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(267, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "电话";
            // 
            // CreateTime
            // 
            this.CreateTime.CalendarFont = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CreateTime.Location = new System.Drawing.Point(99, 115);
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Size = new System.Drawing.Size(156, 21);
            this.CreateTime.TabIndex = 27;
            this.CreateTime.Value = new System.DateTime(2020, 11, 15, 19, 55, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(2, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "雇佣日期";
            // 
            // teachnum
            // 
            this.teachnum.AutoSize = true;
            this.teachnum.Font = new System.Drawing.Font("宋体", 15F);
            this.teachnum.Location = new System.Drawing.Point(98, 0);
            this.teachnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teachnum.Name = "teachnum";
            this.teachnum.Size = new System.Drawing.Size(49, 20);
            this.teachnum.TabIndex = 34;
            this.teachnum.Text = "默认";
            // 
            // wrongtips
            // 
            this.wrongtips.AutoSize = true;
            this.wrongtips.Font = new System.Drawing.Font("宋体", 15F);
            this.wrongtips.ForeColor = System.Drawing.Color.Red;
            this.wrongtips.Location = new System.Drawing.Point(30, 229);
            this.wrongtips.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongtips.Name = "wrongtips";
            this.wrongtips.Size = new System.Drawing.Size(0, 20);
            this.wrongtips.TabIndex = 34;
            // 
            // ChangeTeachInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 287);
            this.Controls.Add(this.wrongtips);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.deleteBtn);
            this.Name = "ChangeTeachInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChangeTeachInfo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox specialty;
        private System.Windows.Forms.TextBox telnum;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker CreateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label teachnum;
        private System.Windows.Forms.Label wrongtips;
    }
}