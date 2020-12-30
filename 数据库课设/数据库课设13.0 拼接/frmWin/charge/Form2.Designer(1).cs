﻿
namespace frmWin.charge
{
    partial class Form2
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
            this.chargeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_stuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_teachId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_chargeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDormTypeName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.chargeId,
            this.chargeName,
            this.fk_stuId,
            this.fk_teachId,
            this.payWay,
            this.fk_chargeId});
            this.dgvDormType.Location = new System.Drawing.Point(62, 143);
            this.dgvDormType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDormType.Name = "dgvDormType";
            this.dgvDormType.RowHeadersWidth = 51;
            this.dgvDormType.RowTemplate.Height = 27;
            this.dgvDormType.Size = new System.Drawing.Size(763, 250);
            this.dgvDormType.TabIndex = 12;
            // 
            // chargeId
            // 
            this.chargeId.DataPropertyName = "chargeId";
            this.chargeId.HeaderText = "主键";
            this.chargeId.MinimumWidth = 6;
            this.chargeId.Name = "chargeId";
            this.chargeId.Width = 125;
            // 
            // chargeName
            // 
            this.chargeName.DataPropertyName = "chargeName";
            this.chargeName.HeaderText = "费用名称";
            this.chargeName.MinimumWidth = 6;
            this.chargeName.Name = "chargeName";
            this.chargeName.Width = 125;
            // 
            // fk_stuId
            // 
            this.fk_stuId.DataPropertyName = "fk_stuId";
            this.fk_stuId.HeaderText = "学生Id";
            this.fk_stuId.MinimumWidth = 6;
            this.fk_stuId.Name = "fk_stuId";
            this.fk_stuId.Width = 125;
            // 
            // fk_teachId
            // 
            this.fk_teachId.DataPropertyName = "fk_teachId";
            this.fk_teachId.HeaderText = "教师Id";
            this.fk_teachId.MinimumWidth = 6;
            this.fk_teachId.Name = "fk_teachId";
            this.fk_teachId.Width = 125;
            // 
            // payWay
            // 
            this.payWay.DataPropertyName = "payWay";
            this.payWay.HeaderText = "支付方式";
            this.payWay.MinimumWidth = 6;
            this.payWay.Name = "payWay";
            this.payWay.Width = 125;
            // fk_chargeId
            // 
            this.fk_chargeId.DataPropertyName = "fk_chargeId";
            this.fk_chargeId.HeaderText = "种类号";
            this.fk_chargeId.MinimumWidth = 6;
            this.fk_chargeId.Name = "fk_chargeId";
            this.fk_chargeId.Width = 125;
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
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "主键";
            // 
            // cboDormTypeName
            // 
            this.cboDormTypeName.FormattingEnabled = true;
            this.cboDormTypeName.Location = new System.Drawing.Point(153, 70);
            this.cboDormTypeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDormTypeName.Name = "cboDormTypeName";
            this.cboDormTypeName.Size = new System.Drawing.Size(156, 26);
            this.cboDormTypeName.TabIndex = 17;
            this.cboDormTypeName.SelectedIndexChanged += new System.EventHandler(this.cboDormTypeName_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 60);
            this.button1.TabIndex = 18;
            this.button1.Text = "插入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Text = "费用信息查询";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_stuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_teachId;
        private System.Windows.Forms.DataGridViewTextBoxColumn payWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_chargeId;
    }
}