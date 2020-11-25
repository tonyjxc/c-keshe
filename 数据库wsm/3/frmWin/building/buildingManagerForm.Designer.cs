namespace frmWin.building
{
    partial class buildingManagerForm
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
            this.txtDromName = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvbuilding = new System.Windows.Forms.DataGridView();
            this.buildid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "宿舍楼名称";
            // 
            // txtDromName
            // 
            this.txtDromName.Location = new System.Drawing.Point(167, 27);
            this.txtDromName.Name = "txtDromName";
            this.txtDromName.Size = new System.Drawing.Size(205, 25);
            this.txtDromName.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(401, 30);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(82, 363);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "首页";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dgvbuilding
            // 
            this.dgvbuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuilding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildid,
            this.buildName,
            this.dormCount,
            this.dormFloor});
            this.dgvbuilding.Location = new System.Drawing.Point(82, 94);
            this.dgvbuilding.Name = "dgvbuilding";
            this.dgvbuilding.RowHeadersWidth = 51;
            this.dgvbuilding.RowTemplate.Height = 27;
            this.dgvbuilding.Size = new System.Drawing.Size(523, 217);
            this.dgvbuilding.TabIndex = 4;
            // 
            // buildid
            // 
            this.buildid.DataPropertyName = "buildid";
            this.buildid.HeaderText = "宿舍楼编号";
            this.buildid.MinimumWidth = 6;
            this.buildid.Name = "buildid";
            this.buildid.Width = 125;
            // 
            // buildName
            // 
            this.buildName.DataPropertyName = "buildName";
            this.buildName.HeaderText = "宿舍楼名称";
            this.buildName.MinimumWidth = 6;
            this.buildName.Name = "buildName";
            this.buildName.Width = 125;
            // 
            // dormCount
            // 
            this.dormCount.DataPropertyName = "dormCount";
            this.dormCount.HeaderText = "宿舍总数";
            this.dormCount.MinimumWidth = 6;
            this.dormCount.Name = "dormCount";
            this.dormCount.Width = 125;
            // 
            // dormFloor
            // 
            this.dormFloor.DataPropertyName = "dormFloor";
            this.dormFloor.HeaderText = "楼层数量";
            this.dormFloor.MinimumWidth = 6;
            this.dormFloor.Name = "dormFloor";
            this.dormFloor.Width = 125;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(178, 363);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "上一页";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(436, 363);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(530, 363);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = "尾页";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblPage
            // 
            this.lblPage.Location = new System.Drawing.Point(82, 318);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(523, 25);
            this.lblPage.TabIndex = 8;
            // 
            // buildingManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 422);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.dgvbuilding);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtDromName);
            this.Controls.Add(this.label1);
            this.Name = "buildingManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宿舍楼管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.buildingManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.buildingManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuilding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDromName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dgvbuilding;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildid;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormFloor;
        private System.Windows.Forms.TextBox lblPage;
    }
}