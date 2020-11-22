namespace frmWin.dorm
{
    partial class dormManageForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.cboFlag = new System.Windows.Forms.ComboBox();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.dormId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "宿舍名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "宿舍状态";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(138, 22);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(100, 25);
            this.txtTypeName.TabIndex = 2;
            // 
            // cboFlag
            // 
            this.cboFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFlag.FormattingEnabled = true;
            this.cboFlag.Location = new System.Drawing.Point(335, 24);
            this.cboFlag.Name = "cboFlag";
            this.cboFlag.Size = new System.Drawing.Size(148, 23);
            this.cboFlag.TabIndex = 29;
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dormId,
            this.dormNum,
            this.personCount});
            this.dgvTeacher.Location = new System.Drawing.Point(51, 83);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.RowHeadersWidth = 51;
            this.dgvTeacher.RowTemplate.Height = 27;
            this.dgvTeacher.Size = new System.Drawing.Size(531, 223);
            this.dgvTeacher.TabIndex = 30;
            // 
            // dormId
            // 
            this.dormId.DataPropertyName = "dormId";
            this.dormId.HeaderText = "宿舍编号";
            this.dormId.MinimumWidth = 6;
            this.dormId.Name = "dormId";
            this.dormId.Width = 125;
            // 
            // dormNum
            // 
            this.dormNum.DataPropertyName = "dormNum";
            this.dormNum.HeaderText = "宿舍名称";
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
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(51, 348);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 31;
            this.btnFirst.Text = "首页";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(138, 348);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 32;
            this.btnPrev.Text = "上一页";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(408, 348);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 33;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(507, 348);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 34;
            this.btnLast.Text = "尾页";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblPage
            // 
            this.lblPage.Location = new System.Drawing.Point(51, 313);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(531, 25);
            this.lblPage.TabIndex = 35;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(507, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 36;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dormManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 407);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.cboFlag);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dormManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宿舍管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dormManageForm_FormClosed);
            this.Load += new System.EventHandler(this.dormManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.ComboBox cboFlag;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn personCount;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox lblPage;
        private System.Windows.Forms.Button btnFind;
    }
}