namespace frmWin.building
{
    partial class buildingManagerFrm2
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
            this.dgvbuilding = new System.Windows.Forms.DataGridView();
            this.buildid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDromName = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbuilding
            // 
            this.dgvbuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuilding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildid,
            this.buildName,
            this.dormCount,
            this.dormFloor});
            this.dgvbuilding.Location = new System.Drawing.Point(44, 73);
            this.dgvbuilding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvbuilding.Name = "dgvbuilding";
            this.dgvbuilding.RowHeadersWidth = 51;
            this.dgvbuilding.RowTemplate.Height = 27;
            this.dgvbuilding.Size = new System.Drawing.Size(707, 180);
            this.dgvbuilding.TabIndex = 13;
            this.dgvbuilding.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbuilding_CellContentClick);
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
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(311, 23);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(67, 34);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "宿舍楼名称";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExit.Location = new System.Drawing.Point(658, 270);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 40);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDromName
            // 
            this.txtDromName.Font = new System.Drawing.Font("宋体", 15F);
            this.txtDromName.FormattingEnabled = true;
            this.txtDromName.Location = new System.Drawing.Point(108, 26);
            this.txtDromName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDromName.Name = "txtDromName";
            this.txtDromName.Size = new System.Drawing.Size(180, 28);
            this.txtDromName.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(531, 270);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 40);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(44, 270);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(78, 40);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "插入新楼";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // buildingManagerFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 390);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDromName);
            this.Controls.Add(this.dgvbuilding);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "buildingManagerFrm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buildingManagerFrmw";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.buildingManagerFrm2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuilding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildid;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormFloor;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox txtDromName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}