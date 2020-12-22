namespace frmWin.dorm
{
    partial class dormManageFrm2
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
            this.btnFind = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvDorm = new System.Windows.Forms.DataGridView();
            this.stuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuildName = new System.Windows.Forms.ComboBox();
            this.txtDormName = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.btnFindStu = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDorm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(410, 74);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(81, 38);
            this.btnFind.TabIndex = 47;
            this.btnFind.Text = "查询2";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(576, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 50);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvDorm
            // 
            this.dgvDorm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDorm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuName,
            this.buildName,
            this.dormNum,
            this.personCount,
            this.flag});
            this.dgvDorm.Location = new System.Drawing.Point(28, 127);
            this.dgvDorm.Name = "dgvDorm";
            this.dgvDorm.RowHeadersWidth = 51;
            this.dgvDorm.RowTemplate.Height = 27;
            this.dgvDorm.Size = new System.Drawing.Size(716, 224);
            this.dgvDorm.TabIndex = 41;
            // 
            // stuName
            // 
            this.stuName.DataPropertyName = "stuName";
            this.stuName.HeaderText = "学生姓名";
            this.stuName.MinimumWidth = 6;
            this.stuName.Name = "stuName";
            this.stuName.Width = 125;
            // 
            // buildName
            // 
            this.buildName.DataPropertyName = "buildName";
            this.buildName.HeaderText = "楼号";
            this.buildName.MinimumWidth = 6;
            this.buildName.Name = "buildName";
            this.buildName.Width = 125;
            // 
            // dormNum
            // 
            this.dormNum.DataPropertyName = "dormNum";
            this.dormNum.HeaderText = "宿舍号";
            this.dormNum.MinimumWidth = 6;
            this.dormNum.Name = "dormNum";
            this.dormNum.Width = 125;
            // 
            // personCount
            // 
            this.personCount.DataPropertyName = "personCount";
            this.personCount.HeaderText = "宿舍人数";
            this.personCount.MinimumWidth = 6;
            this.personCount.Name = "personCount";
            this.personCount.Width = 125;
            // 
            // flag
            // 
            this.flag.DataPropertyName = "flag";
            this.flag.HeaderText = "状态";
            this.flag.MinimumWidth = 6;
            this.flag.Name = "flag";
            this.flag.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "宿舍号";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(443, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 50);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "宿舍楼";
            // 
            // txtBuildName
            // 
            this.txtBuildName.FormattingEnabled = true;
            this.txtBuildName.Location = new System.Drawing.Point(83, 83);
            this.txtBuildName.Name = "txtBuildName";
            this.txtBuildName.Size = new System.Drawing.Size(107, 23);
            this.txtBuildName.TabIndex = 51;
            // 
            // txtDormName
            // 
            this.txtDormName.FormattingEnabled = true;
            this.txtDormName.Location = new System.Drawing.Point(264, 83);
            this.txtDormName.Name = "txtDormName";
            this.txtDormName.Size = new System.Drawing.Size(121, 23);
            this.txtDormName.TabIndex = 52;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(28, 377);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(113, 50);
            this.btnInsert.TabIndex = 53;
            this.btnInsert.Text = "插入新宿舍";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(507, 74);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(160, 42);
            this.btnview.TabIndex = 54;
            this.btnview.Text = "点击查看详情";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "查询学生所在宿舍";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(161, 24);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(158, 25);
            this.txtStuName.TabIndex = 56;
            // 
            // btnFindStu
            // 
            this.btnFindStu.Location = new System.Drawing.Point(335, 11);
            this.btnFindStu.Name = "btnFindStu";
            this.btnFindStu.Size = new System.Drawing.Size(81, 38);
            this.btnFindStu.TabIndex = 57;
            this.btnFindStu.Text = "查询1";
            this.btnFindStu.UseVisualStyleBackColor = true;
            this.btnFindStu.Click += new System.EventHandler(this.btnFindStu_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(589, 13);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(93, 42);
            this.btnChange.TabIndex = 58;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 59;
            this.label4.Text = "跳转寝室卫生分修改";
            // 
            // dormManageFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnFindStu);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtDormName);
            this.Controls.Add(this.txtBuildName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvDorm);
            this.Controls.Add(this.label1);
            this.Name = "dormManageFrm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dormManageFrm2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dormManageFrm2_FormClosing);
            this.Load += new System.EventHandler(this.dormManageFrm2_Load);
            this.MdiChildActivate += new System.EventHandler(this.dormManageFrm2_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDorm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvDorm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtBuildName;
        private System.Windows.Forms.ComboBox txtDormName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn personCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn flag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Button btnFindStu;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label4;
    }
}