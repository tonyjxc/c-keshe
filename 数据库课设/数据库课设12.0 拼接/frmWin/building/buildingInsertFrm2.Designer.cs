﻿namespace frmWin.building
{
    partial class buildingInsertFrm2
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtdormFloor = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtbuildName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(307, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 44);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(205, 253);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 44);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtdormFloor
            // 
            this.txtdormFloor.Location = new System.Drawing.Point(185, 143);
            this.txtdormFloor.Name = "txtdormFloor";
            this.txtdormFloor.Size = new System.Drawing.Size(181, 25);
            this.txtdormFloor.TabIndex = 13;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(185, 82);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(181, 25);
            this.txtMemo.TabIndex = 12;
            // 
            // txtbuildName
            // 
            this.txtbuildName.Enabled = false;
            this.txtbuildName.Location = new System.Drawing.Point(185, 25);
            this.txtbuildName.Name = "txtbuildName";
            this.txtbuildName.Size = new System.Drawing.Size(181, 25);
            this.txtbuildName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "楼层总数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "房间总数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "宿舍楼名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "性别";
            // 
            // cmbsex
            // 
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Location = new System.Drawing.Point(185, 194);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(181, 23);
            this.cmbsex.TabIndex = 18;
            // 
            // buildingInsertFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 358);
            this.Controls.Add(this.cmbsex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtdormFloor);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtbuildName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "buildingInsertFrm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buildingInsertFrm2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.buildingInsertFrm2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtdormFloor;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtbuildName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbsex;
    }
}