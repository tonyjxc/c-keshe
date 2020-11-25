namespace frmWin.dormType
{
    partial class dormTypeManageForm
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
            this.txtTeachTypeName = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvTeachType = new System.Windows.Forms.DataGridView();
            this.typeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型名称";
            // 
            // txtTeachTypeName
            // 
            this.txtTeachTypeName.Location = new System.Drawing.Point(143, 18);
            this.txtTeachTypeName.Name = "txtTeachTypeName";
            this.txtTeachTypeName.Size = new System.Drawing.Size(100, 25);
            this.txtTeachTypeName.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(307, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvTeachType
            // 
            this.dgvTeachType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeId,
            this.typeName,
            this.personCount,
            this.price,
            this.sex,
            this.memo});
            this.dgvTeachType.Location = new System.Drawing.Point(60, 90);
            this.dgvTeachType.Name = "dgvTeachType";
            this.dgvTeachType.RowHeadersWidth = 51;
            this.dgvTeachType.RowTemplate.Height = 27;
            this.dgvTeachType.Size = new System.Drawing.Size(801, 208);
            this.dgvTeachType.TabIndex = 3;
            // 
            // typeId
            // 
            this.typeId.DataPropertyName = "typeId";
            this.typeId.HeaderText = "类型编号";
            this.typeId.MinimumWidth = 6;
            this.typeId.Name = "typeId";
            this.typeId.Width = 125;
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
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(60, 362);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "首页";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(156, 362);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "上一页";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(547, 362);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(648, 362);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = "尾页";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblPage
            // 
            this.lblPage.Location = new System.Drawing.Point(60, 313);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(674, 25);
            this.lblPage.TabIndex = 8;
            // 
            // dormTypeManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.dgvTeachType);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtTeachTypeName);
            this.Controls.Add(this.label1);
            this.Name = "dormTypeManageForm";
            this.Text = "宿舍类型管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dormTypeManageForm_FormClosed);
            this.Load += new System.EventHandler(this.dormTypeManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeachTypeName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgvTeachType;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn personCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn memo;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox lblPage;
    }
}