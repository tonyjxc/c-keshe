
namespace frmWin.teacher
{
    partial class Form2
    { /// <summary>
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvDormType = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDormTypeName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.主键 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edulevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDormType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(716, 443);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 60);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(549, 443);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 60);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvDormType
            // 
            this.dgvDormType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDormType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.主键,
            this.teachName,
            this.teachUserName,
            this.teachPass,
            this.sex,
            this.edulevel,
            this.specialty,
            this.tel,
            this.address,
            this.memo,
            this.hireDate});
            this.dgvDormType.Location = new System.Drawing.Point(62, 143);
            this.dgvDormType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDormType.Name = "dgvDormType";
            this.dgvDormType.RowHeadersWidth = 51;
            this.dgvDormType.RowTemplate.Height = 27;
            this.dgvDormType.Size = new System.Drawing.Size(763, 250);
            this.dgvDormType.TabIndex = 12;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(351, 59);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(98, 47);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "教师编号";
            // 
            // cboDormTypeName
            // 
            this.cboDormTypeName.FormattingEnabled = true;
            this.cboDormTypeName.Location = new System.Drawing.Point(153, 70);
            this.cboDormTypeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDormTypeName.Name = "cboDormTypeName";
            this.cboDormTypeName.Size = new System.Drawing.Size(156, 26);
            this.cboDormTypeName.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 60);
            this.button1.TabIndex = 18;
            this.button1.Text = "插入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 主键
            // 
            this.主键.DataPropertyName = "teachId";
            this.主键.HeaderText = "主键";
            this.主键.MinimumWidth = 6;
            this.主键.Name = "主键";
            this.主键.Width = 125;
            // 
            // teachName
            // 
            this.teachName.DataPropertyName = "teachName";
            this.teachName.HeaderText = "姓名";
            this.teachName.MinimumWidth = 6;
            this.teachName.Name = "teachName";
            this.teachName.Width = 125;
            // 
            // teachUserName
            // 
            this.teachUserName.DataPropertyName = "teachUserName";
            this.teachUserName.HeaderText = "用户名";
            this.teachUserName.MinimumWidth = 6;
            this.teachUserName.Name = "teachUserName";
            this.teachUserName.Width = 125;
            // 
            // teachPass
            // 
            this.teachPass.DataPropertyName = "teachPass";
            this.teachPass.HeaderText = "密码";
            this.teachPass.MinimumWidth = 6;
            this.teachPass.Name = "teachPass";
            this.teachPass.Width = 125;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.Width = 125;
            // 
            // edulevel
            // 
            this.edulevel.DataPropertyName = "edulevel";
            this.edulevel.HeaderText = "受教育程度";
            this.edulevel.MinimumWidth = 6;
            this.edulevel.Name = "edulevel";
            this.edulevel.Width = 125;
            // 
            // specialty
            // 
            this.specialty.DataPropertyName = "specialty";
            this.specialty.HeaderText = "专业";
            this.specialty.MinimumWidth = 6;
            this.specialty.Name = "specialty";
            this.specialty.Width = 125;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "电话";
            this.tel.MinimumWidth = 6;
            this.tel.Name = "tel";
            this.tel.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "地址";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 125;
            // 
            // memo
            // 
            this.memo.DataPropertyName = "memo";
            this.memo.HeaderText = "备注";
            this.memo.MinimumWidth = 6;
            this.memo.Name = "memo";
            this.memo.Width = 125;
            // 
            // hireDate
            // 
            this.hireDate.DataPropertyName = "hireDate";
            this.hireDate.HeaderText = "入职日期";
            this.hireDate.MinimumWidth = 6;
            this.hireDate.Name = "hireDate";
            this.hireDate.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboDormTypeName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvDormType);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "教师信息查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dormTypeManageFrm2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDormType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvDormType;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDormTypeName;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 主键;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn edulevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDate;
    }
}