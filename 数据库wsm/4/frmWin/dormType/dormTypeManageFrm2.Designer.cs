namespace frmWin.dormType
{
    partial class dormTypeManageFrm2
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvDormType = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDormTypeName = new System.Windows.Forms.ComboBox();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDormType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(636, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 50);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(488, 369);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 50);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvDormType
            // 
            this.dgvDormType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDormType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeName,
            this.personCount,
            this.price,
            this.sex,
            this.memo});
            this.dgvDormType.Location = new System.Drawing.Point(55, 119);
            this.dgvDormType.Name = "dgvDormType";
            this.dgvDormType.RowHeadersWidth = 51;
            this.dgvDormType.RowTemplate.Height = 27;
            this.dgvDormType.Size = new System.Drawing.Size(678, 208);
            this.dgvDormType.TabIndex = 12;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(312, 49);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 39);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "类型名称";
            // 
            // cboDormTypeName
            // 
            this.cboDormTypeName.FormattingEnabled = true;
            this.cboDormTypeName.Location = new System.Drawing.Point(136, 58);
            this.cboDormTypeName.Name = "cboDormTypeName";
            this.cboDormTypeName.Size = new System.Drawing.Size(139, 23);
            this.cboDormTypeName.TabIndex = 17;
            // 
            // typeName
            // 
            this.typeName.DataPropertyName = "typeName";
            this.typeName.HeaderText = "类型名称";
            this.typeName.MinimumWidth = 6;
            this.typeName.Name = "typeName";
            this.typeName.Width = 125;
            // 
            // personCount
            // 
            this.personCount.DataPropertyName = "personCount";
            this.personCount.HeaderText = "总人数";
            this.personCount.MinimumWidth = 6;
            this.personCount.Name = "personCount";
            this.personCount.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "价格";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.Width = 125;
            // 
            // memo
            // 
            this.memo.DataPropertyName = "memo";
            this.memo.HeaderText = "备注";
            this.memo.MinimumWidth = 6;
            this.memo.Name = "memo";
            this.memo.Width = 125;
            // 
            // dormTypeManageFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 455);
            this.Controls.Add(this.cboDormTypeName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvDormType);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Name = "dormTypeManageFrm2";
            this.Text = "dormTypeManageFrm2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dormTypeManageFrm2_FormClosing);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn personCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn memo;
    }
}